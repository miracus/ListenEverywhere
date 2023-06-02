using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListenEverywhere.CustomElements
{
    public partial class AudioAlbomsItem : UserControl
    {
        public AudioAlbomsItem()
        {
            InitializeComponent();
            RecursiveHandlerHover(this);
            RecursiveHandlerDoubleClick(this);
        }
        public event EventHandler ListItemChanged;

        #region Recursive Hover
        void RecursiveHandlerHover(Control element)
        {
            element.MouseEnter += Element_MouseEnter;
            element.MouseLeave += Element_MouseLeave;

            foreach (Control innerElement in element.Controls)
            {
                RecursiveHandlerHover(innerElement);
            }
        }

        private void Element_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(40, 40, 40);
        }

        private void Element_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(80, 80, 80);
        }
        #endregion
        #region Recursive Click
        void RecursiveHandlerDoubleClick(Control element)
        {
            element.MouseDoubleClick += Element_MouseDoubleClick;

            foreach (Control innerElement in element.Controls)
            {
                RecursiveHandlerDoubleClick(innerElement);
            }
        }

        private void Element_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListItemChanged.Invoke(this, e);
        }
        #endregion
        #region Custom Options
        public event EventHandler MusicPlay;

        [Category("Властивості плейлиста")]
        public string optTitle
        {
            get
            {
                return albom.Text;
            }
            set
            {
                albom.Text = value;
            }
        }
        [Category("Властивості плейлиста")]
        public string optDescription
        {
            get
            {
                return description.Text;
            }
            set
            {
                description.Text = value;
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

        //string picture;
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
        #endregion
    }
}
