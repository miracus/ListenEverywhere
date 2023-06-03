using ListenEverywhere.CustomElements;
using NAudio.Wave;
using System.Diagnostics;
using System.Windows.Forms;

namespace ListenEverywhere
{
    public partial class Main : Form
    {
        #region Objects create
        PictureBox pictureBox;
        List<AudioTrackItem> audioTrackItemList;
        IWavePlayer? _wavePlayer;
        AudioFileReader? _audioFileReader;
        bool init = false;
        Image prevImage;
        private AudioTrackItem currentAudioTrackItem;
        float volumeLevel = 0.5f;
        private Image playImage;
        private Image pauseImage;
        private Image randomImage;
        private Image repeatImage;
        private Image volumeOnImage;
        private Image volumeOffImage;
        private string currentTimeFormat = @"hh\:mm\:ss";
        private string totalTimeFormat = @"hh\:mm\:ss";
        private string progressFormat = "{0} ({1}%)";


        #endregion
        public Main()
        {
            InitializeComponent();
            Properties.Settings.Default.butMode = "line";
            Properties.Settings.Default.butVolume = "on";

            audioTrackItemList = new List<AudioTrackItem>();
        }

        #region Load Events
        private void Main_Load(object sender, EventArgs e)
        {
            labelVolumePercent.Text = "";
            tlpVolumeSlider.ColumnStyles[0].Width = (int)(volumeLevel * 100);
            tlpVolumeSlider.ColumnStyles[1].Width = 100 - (int)(volumeLevel * 100);

            playImage = Properties.Resources.play;
            pauseImage = Properties.Resources.pause;
            randomImage = Properties.Resources.random;
            repeatImage = Properties.Resources.repeat;
            volumeOnImage = Properties.Resources.volumeon;
            volumeOffImage = Properties.Resources.volumeoff;

            Properties.Settings.Default.folderPath = Directory.GetDirectories("Music/")[0];
            string[] dirs = Directory.GetDirectories("./Music");

            foreach (string dir in dirs)
            {
                AudioAlbomsItem listDirectory = new AudioAlbomsItem();
                DirectoryInfo directory = new DirectoryInfo(dir);

                string input = directory.Name;
                string[] parts = input.Split('-');

                listDirectory.optTitle = parts[0].Trim();
                listDirectory.optDescription = parts[1].Trim();
                listDirectory.FilePath = directory.FullName;
                listDirectory.ListItemChanged += Main_ListItemChanged;

                string[] files = Directory.GetFiles(dir, "cover.*");

                if (files.Length > 0)
                {
                    string coverFilePath = files[0];
                    listDirectory.Picture = new Bitmap(coverFilePath);
                }

                flpAlbom.Controls.Add(listDirectory);
            }

            AudioAlbomsItem? trackDirectory = flpAlbom.Controls[0] as AudioAlbomsItem;
            if (trackDirectory != null)
            {
                Main_ShowPlayList(trackDirectory);
            }
        }

        private void Main_ListItemChanged(object? sender, EventArgs e)
        {
            AudioAlbomsItem? trackDirectory = sender as AudioAlbomsItem;
            if (trackDirectory != null)
            {
                Main_ShowPlayList(trackDirectory);
            }
        }


        public void Main_ShowPlayList(AudioAlbomsItem trackDirectory)
        {
            flpTrack.Visible = false;
            flpTrack.Controls.Clear();
            audioTrackItemList.Clear();

            string[] files = Directory.GetFiles(trackDirectory.FilePath, "*.mp3");
            foreach (string musicTrack in files)
            {
                FileInfo file = new FileInfo(musicTrack);
                AudioTrackItem newTrack = new AudioTrackItem();

                TagLib.File fileTag = TagLib.File.Create(musicTrack);
                newTrack.FilePath = file.FullName;

                if (fileTag.Tag.FirstPerformer == "") newTrack.AuthorName = file.Name;
                else newTrack.AuthorName = fileTag.Tag.FirstPerformer;


                if (fileTag.Tag.Title == "") newTrack.TrackName = file.Name.Replace(".mp3", "");
                else newTrack.TrackName = fileTag.Tag.Title;

                fileTag.Dispose();

                string[] filesPicture = Directory.GetFiles(trackDirectory.FilePath, "cover.*");
                if (filesPicture.Length > 0)
                {
                    string coverFilePath = filesPicture[0];
                    newTrack.Picture = new Bitmap(coverFilePath);
                }
                newTrack.MusicPlay += Main_NewTrack_MusicPlay;
                newTrack.MusicHover += Main_NewTrack_MusicHover;
                newTrack.Pause += Pause;
                newTrack.PlayAfterPause += PlayAfterPause;
                currentAudioTrackItem = newTrack;
                audioTrackItemList.Add(newTrack);
                flpTrack.Controls.Add(newTrack);
            }
            flpTrack.Visible = true;
        }

        #endregion
        #region Hover Play Button

        AudioTrackItem hover;
        private void Main_NewTrack_MusicHover(object? sender, EventArgs e)
        {
            if (sender is AudioTrackItem audioRightItem && hover != audioRightItem)
            {
                if (hover != null)
                {
                    hover.ButtonVisible = false;
                }
                hover = audioRightItem;
                hover.ButtonVisible = true;
            }
        }

        #endregion
        #region Play and Mode

        AudioTrackItem play;
        private void Main_NewTrack_MusicPlay(object sender, EventArgs e)
        {
            if (sender is AudioTrackItem audioTrackItem)
            {
                AudioTrackItem track = audioTrackItem;
                prevImage = track.Picture;
                track.IsPlaying = true;
                track.Picture = Properties.Resources.finished_gif;
                track.ButtonPlay = false;
                Properties.Settings.Default.modePlay = "Pause";
                foreach (AudioTrackItem audioItem in audioTrackItemList)
                {
                    if (audioItem != track)
                    {
                        play = track;
                        audioItem.ButtonPlay = false;
                        Properties.Settings.Default.modePlay = "Play";
                        audioItem.IsPlaying = false;
                        audioItem.Picture = prevImage;
                    }
                    else
                    {
                        audioItem.ButtonPlay = true;
                    }
                }
                tlpBar.RowStyles[0].SizeType = SizeType.Percent;
                tlpBar.RowStyles[0].Height = 75F;

                tlpBar.RowStyles[1].SizeType = SizeType.Percent;
                tlpBar.RowStyles[1].Height = 25F;
                Main_Play(track);
            }
        }

        public void Main_Play(AudioTrackItem track)
        {
            if (_wavePlayer != null && _audioFileReader != null)
            {
                _wavePlayer.Stop(); // Зупинити програвання
                _wavePlayer.Dispose(); // Звільнити ресурси WaveOut
                _audioFileReader.Dispose(); // Звільнити ресурси AudioFileReader
                timerMainTrack.Stop(); // Зупинити таймер
            }

            Properties.Settings.Default.descriptionSong = track.AuthorName + " - " + track.TrackName;

            _wavePlayer = new WaveOut();
            _audioFileReader = new AudioFileReader(track.FilePath);
            _wavePlayer.Init(_audioFileReader);
            _wavePlayer.Play();
            timerMainTrack.Start();
            Properties.Settings.Default.modePlay = "Play";
        }

        public void Pause(object? sender, EventArgs e)
        {
            play.ButtonPlay = false;
            _wavePlayer?.Pause();
            Properties.Settings.Default.modePlay = "Pause";
            currentAudioTrackItem.ButtonPlay = false;
            currentAudioTrackItem.BackgroundImage = Properties.Resources.pause;
        }

        public void PlayAfterPause(object? sender, EventArgs e)
        {
            play.ButtonPlay = true;
            _wavePlayer?.Play();
            Properties.Settings.Default.modePlay = "Play";
            currentAudioTrackItem.ButtonPlay = true;
            currentAudioTrackItem.BackgroundImage = Properties.Resources.play;
        }
        #endregion
        #region Audio Track Bar Event
        private void ButtonControlClick(object sender, EventArgs e)
        {
            if (sender == butPlayPause)
            {
                if (Properties.Settings.Default.modePlay == "Pause")
                {
                    PlayAfterPause(sender, e);
                    return;
                }
                if (Properties.Settings.Default.modePlay == "Play")
                {
                    Pause(sender, e);
                    return;
                }
            }
            else if (sender == butFolder)
            {
                string relativeFolderPath = Properties.Settings.Default.folderPath;
                string currentDirectory = Directory.GetCurrentDirectory();
                string absoluteFolderPath = Path.GetFullPath(Path.Combine(currentDirectory, relativeFolderPath));

                // Встановлення поточного робочого каталогу
                Directory.SetCurrentDirectory(currentDirectory);

                // Відкриття папки у провіднику
                Process.Start("explorer.exe", $"/select, \"{absoluteFolderPath}\"");
            }
            else if (sender == butMode)
            {

                if (Properties.Settings.Default.butMode == "line")
                {
                    Properties.Settings.Default.butMode = "random";
                    return;
                }
                if (Properties.Settings.Default.butMode == "random")
                {
                    Properties.Settings.Default.butMode = "line";
                    return;
                }

            }
            else if (sender == butNext)
            {

                if (Properties.Settings.Default.butMode == "line")
                {
                    int index = flpTrack.Controls.IndexOf(play);
                    if (index + 1 == flpTrack.Controls.Count)
                    {
                        index = -1;
                    }
                    Control nextTrack = flpTrack.Controls[index + 1];
                    Main_NewTrack_MusicPlay(nextTrack, e);
                }
                else if (Properties.Settings.Default.butMode == "random")
                {
                    Random random = new Random();
                    int index = flpTrack.Controls.IndexOf(play);
                    int rand = random.Next(0, flpTrack.Controls.Count);
                    if (rand != index)
                    {
                        Control nextTrack = flpTrack.Controls[rand];
                        Main_NewTrack_MusicPlay(nextTrack, e);
                    }
                    else
                    {
                        Control nextTrack = flpTrack.Controls[index - 1];
                        Main_NewTrack_MusicPlay(nextTrack, e);
                    }

                }


            }
            else if (sender == butPrev)
            {
                int index = flpTrack.Controls.IndexOf(play);
                if (index == 0)
                {
                    index = flpTrack.Controls.Count;
                }
                Control prevTrack = flpTrack.Controls[index - 1];
                Main_NewTrack_MusicPlay(prevTrack, e);
            }
            else if (sender == butStop)
            {
                if (_audioFileReader != null)
                {
                    _audioFileReader.Position = 0;
                    _wavePlayer.Stop(); // Зупинити програвання
                    _wavePlayer.Dispose(); // Звільнити ресурси WaveOut
                    _audioFileReader.Dispose(); // Звільнити ресурси AudioFileReader
                    timerMainTrack.Stop(); // Зупинити таймер
                    Properties.Settings.Default.modePlay = "Stop";

                    tlpBar.RowStyles[0].SizeType = SizeType.Percent;
                    tlpBar.RowStyles[0].Height = 100F;
                    tlpBar.RowStyles[1].SizeType = SizeType.Percent;
                    tlpBar.RowStyles[1].Height = 0F;

                    foreach (AudioTrackItem audioItem in audioTrackItemList)
                    {
                        audioItem.Picture = prevImage;
                        audioItem.ButtonPicture = Properties.Resources.play;
                    }
                }
            }
            else if (sender == butVolume)
            {
                if (Properties.Settings.Default.butVolume == "on")
                {
                    Properties.Settings.Default.butVolume = "off";
                    _wavePlayer.Volume = 0f;
                    return;
                }
                if (Properties.Settings.Default.butVolume == "off")
                {
                    Properties.Settings.Default.butVolume = "on";
                    _wavePlayer.Volume = volumeLevel;
                    return;
                }
            }
        }




        private void tlpProgress_MouseClick(object sender, MouseEventArgs e)
        {
            double persent = (double)e.X / tlpTrackDuration.Width;
            if (_audioFileReader != null)
            {
                TimeSpan result = _audioFileReader.TotalTime * persent;
                _audioFileReader.CurrentTime = result;
            }
        }

        #region Timers
        private void timerMainAnimation_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.modePlay == "Pause")
            {
                butPlayPause.Image = playImage;
            }
            if (Properties.Settings.Default.modePlay == "Play")
            {
                butPlayPause.Image = pauseImage;
            }

            if (Properties.Settings.Default.butMode == "line")
            {
                butMode.Image = randomImage;
            }
            if (Properties.Settings.Default.butMode == "random")
            {
                butMode.Image = repeatImage;
            }

            if (Properties.Settings.Default.butVolume == "on")
            {
                butVolume.Image = volumeOffImage;
            }
            if (Properties.Settings.Default.butVolume == "off")
            {
                butVolume.Image = volumeOnImage;
            }

        }

    private void timerMainTrack_Tick(object sender, EventArgs e)
        {
            if (_wavePlayer != null && _audioFileReader != null)
            {
                if (!init)
                {
                    _wavePlayer.Volume = 0.5f;
                    init = true;
                }

                TimeSpan currentTimeValue;
                TimeSpan totalTimeValue;

                currentTimeValue = _audioFileReader.CurrentTime;
                totalTimeValue = _audioFileReader.TotalTime;
                double percentage = (currentTimeValue.TotalSeconds / totalTimeValue.TotalSeconds) * 100.0;
                int roundedPercentage = (int)(percentage + 0.5);
                string currentTimeText = currentTimeValue.ToString(currentTimeFormat);
                string totalTimeText = totalTimeValue.ToString(totalTimeFormat);
                string progressText = string.Format(progressFormat, currentTimeText, roundedPercentage);
                if (roundedPercentage == 100)
                {
                    int index = flpTrack.Controls.IndexOf(play);
                    if (index + 1 == flpTrack.Controls.Count)
                    {
                        index = -1;
                    }
                    Control nextTrack = flpTrack.Controls[index + 1];
                    Main_NewTrack_MusicPlay(nextTrack, e);
                }
                labelCurTimeTrack.Text = progressText;
                labelTotTimeTrack.Text = totalTimeText;
                tlpTrackDuration.ColumnStyles[0].Width = (int)percentage;
                tlpTrackDuration.ColumnStyles[1].Width = 100 - (int)percentage;
                labelDescriptionTrack.Text = Properties.Settings.Default.descriptionSong;

                string volumeText = (_wavePlayer.Volume * 100).ToString("0") + "%";
                labelVolumePercent.Text = volumeText;
            }
        }
        #endregion


        #endregion
        #region Button Audio Track Bar Animation
        private void ButtonControlAnimationEnter(object sender, EventArgs e)
        {

            pictureBox = (PictureBox)sender;
            pictureBox.Anchor = AnchorStyles.Top;
        }

        private void ButtonControlAnimationLeave(object sender, EventArgs e)
        {
            pictureBox = (PictureBox)sender;
            pictureBox.Anchor = AnchorStyles.Bottom;
        }
        private void tlpVolumeSlider_MouseClick(object sender, MouseEventArgs e)
        {
            double percent = (double)e.X / tlpVolumeSlider.Width;
            volumeLevel = (float)percent;
            _wavePlayer.Volume = volumeLevel;
            Properties.Settings.Default.levelVolume = (int)(percent * 100);

            tlpVolumeSlider.ColumnStyles[0].Width = (int)(percent * 100);
            tlpVolumeSlider.ColumnStyles[1].Width = 100 - (int)(percent * 100);

        }
        #endregion


    }
}