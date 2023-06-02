using ListenEverywhere.CustomElements;
using NAudio.Wave;
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

        #endregion
        public Main()
        {
            InitializeComponent();
            audioTrackItemList = new List<AudioTrackItem>();
        }

        #region Load Events
        private void Main_Load(object sender, EventArgs e)
        {

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
                foreach (var item in audioTrackItemList)
                {
                    if (item == track)
                    {
                        play = track;
                        track.ButtonPlay = true;
                        Properties.Settings.Default.modePlay = "Play";
                        //prevImage = item.Picture;
                        //item.Picture = Properties.Resources.finished_gif;
                    }
                    else
                    {
                        item.ButtonPlay = false;
                        Properties.Settings.Default.modePlay = "Pause";
                        //if (prevImage != null)
                        //{
                        //    item.Picture = prevImage;
                        //}
                    }

                }
                Main_Play(track);
            }

            //показати бар після відтворення
            //RowStyle firstRowStyle = mainTable1.RowStyles[0];
            //firstRowStyle.SizeType = SizeType.Percent;
            //firstRowStyle.Height = 75F;
            //RowStyle secondRowStyle = mainTable1.RowStyles[1];
            //secondRowStyle.SizeType = SizeType.Percent;
            //secondRowStyle.Height = 25F;
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
            foreach (var item in audioTrackItemList)
            {
                if (item == track)
                {
                    track.IsPlaying = true;
                }
                else
                {
                    track.IsPlaying = false;
                }

            }

        }

        public class Song
        {
            public bool IsPlaying { get; set; }
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
                butPlayPause.Image = Properties.Resources.play;
            }
            if (Properties.Settings.Default.modePlay == "Play")
            {
                butPlayPause.Image = Properties.Resources.pause;
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
                int roundedPercentage = (int)Math.Round(percentage);
                string currentTimeText = currentTimeValue.ToString(@"hh\:mm\:ss");
                string totalTimeText = totalTimeValue.ToString(@"hh\:mm\:ss");
                if (roundedPercentage == 100)
                {
                    //Properties.Settings.Default.modeEndTrack = true;
                }
                string progressText = $"{currentTimeText} ({roundedPercentage}%)";
                labelCurTimeTrack.Text = progressText;
                labelTotTimeTrack.Text = totalTimeText;
                tlpTrackDuration.ColumnStyles[0].Width = (int)percentage;
                tlpTrackDuration.ColumnStyles[1].Width = 100 - (int)percentage;
                labelDescriptionTrack.Text = Properties.Settings.Default.descriptionSong;
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
        #endregion
>>>>>>>>> Temporary merge branch 2
    }
}