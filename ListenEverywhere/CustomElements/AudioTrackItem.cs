using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListenEverywhere.CustomElements
{
    public partial class AudioTrackItem : UserControl
    {
        #region Objects create
        List<AudioTrackItem> audioTrackItemList;
        IWavePlayer? _wavePlayer;
        public bool ButtonVisible { get; set; }
        public bool ButtonPlay { get; set; }
        public event EventHandler Pause;
        public event EventHandler PlayAfterPause;
        public event EventHandler MusicPlay;
        public event EventHandler MusicHover;
        private Image previousImage;
        #endregion

        public event EventHandler bPlay;
        public AudioTrackItem()
        {
            InitializeComponent();
            AudioTrackItem_RecursiveHandlerHover(itemArea);
            AudioRightItem_RecursiveHandlerDoubleClick(itemArea);
        }

        

        public void UpdatePlayButtonImage()
        {
            if (ButtonPlay)
            {
                playButton.BackgroundImage = Properties.Resources.pause;
            }
            else
            {
                playButton.BackgroundImage = Properties.Resources.play;
            }
        }

        #region Timers
        private void AudioTrack_display_Tick(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.modePlay != "Stop")
            { 
                if (ButtonPlay)
                {
                    playButton.BackgroundImage = Properties.Resources.pause;
                }
                else
                {
                    playButton.BackgroundImage = Properties.Resources.play;
                }
            }



            if (ButtonVisible)
            {
                if (!playButton.Visible)
                {
                    playButton.Visible = true;
                }
                else if (playButton.Top > 80)
                {
                    playButton.Top -= 10;
                }
            }
            else
            {
                if (playButton.Top <= 80)
                {
                    playButton.Top += 10;
                }
                else if (playButton.Visible)
                {
                    playButton.Visible = false;
                }
            }
        }

        #endregion
        #region Play Button
        private void playButton_Click(object sender, EventArgs e)
        {
            if (ButtonPlay)
            {
                if (Properties.Settings.Default.modePlay == "Pause")
                {
                    ButtonPlay = true;
                    PlayAfterPause?.Invoke(sender, e);
                    return;
                }
                if (Properties.Settings.Default.modePlay == "Play")
                {
                    ButtonPlay = false;
                    Pause?.Invoke(sender, e);
                    return;
                }

                ButtonPlay = true;
                MusicPlay?.Invoke(this, e);
                return;
            }
            else
            {
                if (Properties.Settings.Default.modePlay == "Pause")
                {
                    if(IsPlaying)
                    {
                        ButtonPlay = true;
                        PlayAfterPause?.Invoke(sender, e);
                        return;
                    }
                }
                ButtonPlay = true;
                MusicPlay?.Invoke(this, e);
                return;
            }
        }
        #endregion
        #region Recursive Hover
        void AudioTrackItem_RecursiveHandlerHover(Control element)
        {
            element.MouseEnter += AudioTrackItem_Element_MouseEnter;
            element.MouseLeave += AudioTrackItem_Element_MouseLeave;

            foreach (Control innerElement in element.Controls)
            {
                AudioTrackItem_RecursiveHandlerHover(innerElement);
            }
        }

        private void AudioTrackItem_Element_MouseLeave(object? sender, EventArgs e)
        {
            itemArea.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void AudioTrackItem_Element_MouseEnter(object? sender, EventArgs e)
        {
            MusicHover?.Invoke(this, e);
            itemArea.BackColor = Color.FromArgb(80, 80, 80);
        }
        #endregion
        #region Recursive Click
        void AudioRightItem_RecursiveHandlerDoubleClick(Control element)
        {
            element.MouseDoubleClick += AudioTrackItem_Element_MouseDoubleClick;

            foreach (Control innerElement in element.Controls)
            {
                AudioRightItem_RecursiveHandlerDoubleClick(innerElement);
            }
        }
        private void AudioTrackItem_Element_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MusicPlay?.Invoke(this, e);
        }
        #endregion
        #region Options
        [Category("Властивості трека")]
        public string AuthorName
        {
            get
            {
                return authorName.Text;
            }
            set
            {
                authorName.Text = value;
            }
        }
        [Category("Властивості трека")]
        public string TrackName
        {
            get
            {
                return trackName.Text;
            }
            set
            {
                trackName.Text = value;
            }
        }
        string filePath;



        [Category("Властивості трека")]
        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
        }
        [Category("Властивості трека")]
        public bool IsPlaying { get; set; }

        [Category("Властивості трека")]
        public Image Picture
        {
            get
            {
                return pictureBox.Image;
            }
            set
            {
                pictureBox.Image = value;
            }
        }

        [Category("Властивості трека")]
        public Image ButtonPicture
        {
            get
            {
                return playButton.BackgroundImage;
            }
            set
            {
                playButton.BackgroundImage = value;
            }
        }
        #endregion

    }
}
