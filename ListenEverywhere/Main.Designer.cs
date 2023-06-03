namespace ListenEverywhere
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tlpBar = new TableLayoutPanel();
            tlpLists = new TableLayoutPanel();
            flpTrack = new FlowLayoutPanel();
            flpAlbom = new FlowLayoutPanel();
            tlpBarElements = new TableLayoutPanel();
            tlpTrackDuration = new TableLayoutPanel();
            labelDuration = new Label();
            tlpLabelsTrack = new TableLayoutPanel();
            labelTotTimeTrack = new Label();
            labelDescriptionTrack = new Label();
            labelCurTimeTrack = new Label();
            tlpControlElement = new TableLayoutPanel();
            butVolume = new PictureBox();
            butFolder = new PictureBox();
            butMode = new PictureBox();
            butPrev = new PictureBox();
            butPlayPause = new PictureBox();
            butNext = new PictureBox();
            butStop = new PictureBox();
            tlpVolumeSlider = new TableLayoutPanel();
            labelVolumePercent = new Label();
            timerMainAnimation = new System.Windows.Forms.Timer(components);
            timerMainTrack = new System.Windows.Forms.Timer(components);
            tlpBar.SuspendLayout();
            tlpLists.SuspendLayout();
            tlpBarElements.SuspendLayout();
            tlpTrackDuration.SuspendLayout();
            tlpLabelsTrack.SuspendLayout();
            tlpControlElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)butVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butFolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butPrev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butPlayPause).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butStop).BeginInit();
            tlpVolumeSlider.SuspendLayout();
            SuspendLayout();
            // 
            // tlpBar
            // 
            tlpBar.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tlpBar.ColumnCount = 1;
            tlpBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpBar.Controls.Add(tlpLists, 0, 0);
            tlpBar.Controls.Add(tlpBarElements, 0, 1);
            tlpBar.Dock = DockStyle.Fill;
            tlpBar.Location = new Point(0, 0);
            tlpBar.Name = "tlpBar";
            tlpBar.RowCount = 2;
            tlpBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBar.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
            tlpBar.Size = new Size(804, 450);
            tlpBar.TabIndex = 0;
            // 
            // tlpLists
            // 
            tlpLists.ColumnCount = 2;
            tlpLists.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpLists.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpLists.Controls.Add(flpTrack, 1, 0);
            tlpLists.Controls.Add(flpAlbom, 0, 0);
            tlpLists.Dock = DockStyle.Fill;
            tlpLists.Location = new Point(6, 6);
            tlpLists.Name = "tlpLists";
            tlpLists.RowCount = 1;
            tlpLists.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLists.Size = new Size(792, 324);
            tlpLists.TabIndex = 0;
            // 
            // flpTrack
            // 
            flpTrack.AutoScroll = true;
            flpTrack.Dock = DockStyle.Fill;
            flpTrack.Location = new Point(237, 0);
            flpTrack.Margin = new Padding(0);
            flpTrack.Name = "flpTrack";
            flpTrack.Size = new Size(555, 324);
            flpTrack.TabIndex = 0;
            // 
            // flpAlbom
            // 
            flpAlbom.AutoScroll = true;
            flpAlbom.Dock = DockStyle.Fill;
            flpAlbom.Location = new Point(0, 0);
            flpAlbom.Margin = new Padding(0);
            flpAlbom.Name = "flpAlbom";
            flpAlbom.Size = new Size(237, 324);
            flpAlbom.TabIndex = 1;
            // 
            // tlpBarElements
            // 
            tlpBarElements.ColumnCount = 1;
            tlpBarElements.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBarElements.Controls.Add(tlpTrackDuration, 0, 0);
            tlpBarElements.Controls.Add(tlpLabelsTrack, 0, 1);
            tlpBarElements.Controls.Add(tlpControlElement, 0, 2);
            tlpBarElements.Dock = DockStyle.Fill;
            tlpBarElements.Location = new Point(3, 336);
            tlpBarElements.Margin = new Padding(0);
            tlpBarElements.Name = "tlpBarElements";
            tlpBarElements.RowCount = 3;
            tlpBarElements.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpBarElements.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpBarElements.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpBarElements.Size = new Size(798, 111);
            tlpBarElements.TabIndex = 1;
            // 
            // tlpTrackDuration
            // 
            tlpTrackDuration.ColumnCount = 2;
            tlpTrackDuration.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
            tlpTrackDuration.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTrackDuration.Controls.Add(labelDuration, 0, 0);
            tlpTrackDuration.Dock = DockStyle.Fill;
            tlpTrackDuration.Location = new Point(0, 0);
            tlpTrackDuration.Margin = new Padding(0);
            tlpTrackDuration.Name = "tlpTrackDuration";
            tlpTrackDuration.RowCount = 1;
            tlpTrackDuration.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTrackDuration.Size = new Size(798, 22);
            tlpTrackDuration.TabIndex = 0;
            tlpTrackDuration.MouseClick += tlpProgress_MouseClick;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.BackColor = Color.Green;
            labelDuration.Dock = DockStyle.Fill;
            labelDuration.ForeColor = Color.White;
            labelDuration.Location = new Point(3, 0);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(1, 22);
            labelDuration.TabIndex = 0;
            labelDuration.MouseClick += tlpProgress_MouseClick;
            // 
            // tlpLabelsTrack
            // 
            tlpLabelsTrack.ColumnCount = 3;
            tlpLabelsTrack.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpLabelsTrack.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpLabelsTrack.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpLabelsTrack.Controls.Add(labelTotTimeTrack, 2, 0);
            tlpLabelsTrack.Controls.Add(labelDescriptionTrack, 1, 0);
            tlpLabelsTrack.Controls.Add(labelCurTimeTrack, 0, 0);
            tlpLabelsTrack.Dock = DockStyle.Fill;
            tlpLabelsTrack.Location = new Point(3, 25);
            tlpLabelsTrack.Name = "tlpLabelsTrack";
            tlpLabelsTrack.RowCount = 1;
            tlpLabelsTrack.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLabelsTrack.Size = new Size(792, 38);
            tlpLabelsTrack.TabIndex = 1;
            // 
            // labelTotTimeTrack
            // 
            labelTotTimeTrack.AutoSize = true;
            labelTotTimeTrack.Dock = DockStyle.Fill;
            labelTotTimeTrack.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotTimeTrack.ForeColor = SystemColors.ActiveCaption;
            labelTotTimeTrack.Location = new Point(636, 0);
            labelTotTimeTrack.Name = "labelTotTimeTrack";
            labelTotTimeTrack.Size = new Size(153, 38);
            labelTotTimeTrack.TabIndex = 0;
            labelTotTimeTrack.Text = "time";
            labelTotTimeTrack.TextAlign = ContentAlignment.TopRight;
            // 
            // labelDescriptionTrack
            // 
            labelDescriptionTrack.AutoSize = true;
            labelDescriptionTrack.Dock = DockStyle.Fill;
            labelDescriptionTrack.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescriptionTrack.ForeColor = SystemColors.ActiveCaption;
            labelDescriptionTrack.Location = new Point(158, 0);
            labelDescriptionTrack.Margin = new Padding(0);
            labelDescriptionTrack.Name = "labelDescriptionTrack";
            labelDescriptionTrack.Size = new Size(475, 38);
            labelDescriptionTrack.TabIndex = 1;
            labelDescriptionTrack.Text = "descriptionTrack";
            labelDescriptionTrack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCurTimeTrack
            // 
            labelCurTimeTrack.AutoSize = true;
            labelCurTimeTrack.Dock = DockStyle.Fill;
            labelCurTimeTrack.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCurTimeTrack.ForeColor = SystemColors.ActiveCaption;
            labelCurTimeTrack.Location = new Point(3, 0);
            labelCurTimeTrack.Name = "labelCurTimeTrack";
            labelCurTimeTrack.Size = new Size(152, 38);
            labelCurTimeTrack.TabIndex = 2;
            labelCurTimeTrack.Text = "time";
            // 
            // tlpControlElement
            // 
            tlpControlElement.ColumnCount = 8;
            tlpControlElement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpControlElement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpControlElement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpControlElement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpControlElement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpControlElement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpControlElement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpControlElement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpControlElement.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpControlElement.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpControlElement.Controls.Add(butVolume, 1, 0);
            tlpControlElement.Controls.Add(butFolder, 2, 0);
            tlpControlElement.Controls.Add(butMode, 3, 0);
            tlpControlElement.Controls.Add(butPrev, 4, 0);
            tlpControlElement.Controls.Add(butPlayPause, 5, 0);
            tlpControlElement.Controls.Add(butNext, 6, 0);
            tlpControlElement.Controls.Add(butStop, 7, 0);
            tlpControlElement.Controls.Add(tlpVolumeSlider, 0, 0);
            tlpControlElement.Dock = DockStyle.Fill;
            tlpControlElement.Location = new Point(3, 69);
            tlpControlElement.Name = "tlpControlElement";
            tlpControlElement.RowCount = 1;
            tlpControlElement.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpControlElement.Size = new Size(792, 39);
            tlpControlElement.TabIndex = 2;
            // 
            // butVolume
            // 
            butVolume.Anchor = AnchorStyles.Bottom;
            butVolume.Image = Properties.Resources.volumeon;
            butVolume.Location = new Point(251, 4);
            butVolume.Margin = new Padding(0);
            butVolume.Name = "butVolume";
            butVolume.Size = new Size(50, 35);
            butVolume.SizeMode = PictureBoxSizeMode.Zoom;
            butVolume.TabIndex = 0;
            butVolume.TabStop = false;
            butVolume.Click += ButtonControlClick;
            butVolume.MouseEnter += ButtonControlAnimationEnter;
            butVolume.MouseLeave += ButtonControlAnimationLeave;
            // 
            // butFolder
            // 
            butFolder.Anchor = AnchorStyles.Bottom;
            butFolder.Image = Properties.Resources.folder;
            butFolder.Location = new Point(330, 4);
            butFolder.Margin = new Padding(0);
            butFolder.Name = "butFolder";
            butFolder.Size = new Size(50, 35);
            butFolder.SizeMode = PictureBoxSizeMode.Zoom;
            butFolder.TabIndex = 1;
            butFolder.TabStop = false;
            butFolder.Click += ButtonControlClick;
            butFolder.MouseEnter += ButtonControlAnimationEnter;
            butFolder.MouseLeave += ButtonControlAnimationLeave;
            // 
            // butMode
            // 
            butMode.Anchor = AnchorStyles.Bottom;
            butMode.Image = Properties.Resources.random;
            butMode.Location = new Point(409, 4);
            butMode.Margin = new Padding(0);
            butMode.Name = "butMode";
            butMode.Size = new Size(50, 35);
            butMode.SizeMode = PictureBoxSizeMode.Zoom;
            butMode.TabIndex = 2;
            butMode.TabStop = false;
            butMode.Click += ButtonControlClick;
            butMode.MouseEnter += ButtonControlAnimationEnter;
            butMode.MouseLeave += ButtonControlAnimationLeave;
            // 
            // butPrev
            // 
            butPrev.Anchor = AnchorStyles.Bottom;
            butPrev.Image = Properties.Resources.previous;
            butPrev.Location = new Point(488, 4);
            butPrev.Margin = new Padding(0);
            butPrev.Name = "butPrev";
            butPrev.Size = new Size(50, 35);
            butPrev.SizeMode = PictureBoxSizeMode.Zoom;
            butPrev.TabIndex = 3;
            butPrev.TabStop = false;
            butPrev.Click += ButtonControlClick;
            butPrev.MouseEnter += ButtonControlAnimationEnter;
            butPrev.MouseLeave += ButtonControlAnimationLeave;
            // 
            // butPlayPause
            // 
            butPlayPause.Anchor = AnchorStyles.Bottom;
            butPlayPause.Image = Properties.Resources.play;
            butPlayPause.Location = new Point(567, 4);
            butPlayPause.Margin = new Padding(0);
            butPlayPause.Name = "butPlayPause";
            butPlayPause.Size = new Size(50, 35);
            butPlayPause.SizeMode = PictureBoxSizeMode.Zoom;
            butPlayPause.TabIndex = 4;
            butPlayPause.TabStop = false;
            butPlayPause.Click += ButtonControlClick;
            butPlayPause.MouseEnter += ButtonControlAnimationEnter;
            butPlayPause.MouseLeave += ButtonControlAnimationLeave;
            // 
            // butNext
            // 
            butNext.Anchor = AnchorStyles.Bottom;
            butNext.Image = Properties.Resources.next;
            butNext.Location = new Point(646, 4);
            butNext.Margin = new Padding(0);
            butNext.Name = "butNext";
            butNext.Size = new Size(50, 35);
            butNext.SizeMode = PictureBoxSizeMode.Zoom;
            butNext.TabIndex = 5;
            butNext.TabStop = false;
            butNext.Click += ButtonControlClick;
            butNext.MouseEnter += ButtonControlAnimationEnter;
            butNext.MouseLeave += ButtonControlAnimationLeave;
            // 
            // butStop
            // 
            butStop.Anchor = AnchorStyles.Bottom;
            butStop.Image = Properties.Resources.stop;
            butStop.Location = new Point(726, 4);
            butStop.Margin = new Padding(0);
            butStop.Name = "butStop";
            butStop.Size = new Size(50, 35);
            butStop.SizeMode = PictureBoxSizeMode.Zoom;
            butStop.TabIndex = 6;
            butStop.TabStop = false;
            butStop.Click += ButtonControlClick;
            butStop.MouseEnter += ButtonControlAnimationEnter;
            butStop.MouseLeave += ButtonControlAnimationLeave;
            // 
            // tlpVolumeSlider
            // 
            tlpVolumeSlider.BackColor = Color.Black;
            tlpVolumeSlider.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tlpVolumeSlider.ColumnCount = 2;
            tlpVolumeSlider.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
            tlpVolumeSlider.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpVolumeSlider.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpVolumeSlider.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpVolumeSlider.Controls.Add(labelVolumePercent, 0, 0);
            tlpVolumeSlider.Dock = DockStyle.Fill;
            tlpVolumeSlider.Location = new Point(0, 0);
            tlpVolumeSlider.Margin = new Padding(0);
            tlpVolumeSlider.Name = "tlpVolumeSlider";
            tlpVolumeSlider.RowCount = 1;
            tlpVolumeSlider.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpVolumeSlider.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpVolumeSlider.Size = new Size(237, 39);
            tlpVolumeSlider.TabIndex = 7;
            // 
            // labelVolumePercent
            // 
            labelVolumePercent.AutoSize = true;
            labelVolumePercent.BackColor = Color.Green;
            labelVolumePercent.Dock = DockStyle.Fill;
            labelVolumePercent.Location = new Point(2, 2);
            labelVolumePercent.Margin = new Padding(0);
            labelVolumePercent.Name = "labelVolumePercent";
            labelVolumePercent.Size = new Size(1, 35);
            labelVolumePercent.TabIndex = 0;
            labelVolumePercent.Text = "label1";
            labelVolumePercent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerMainAnimation
            // 
            timerMainAnimation.Enabled = true;
            timerMainAnimation.Interval = 10;
            timerMainAnimation.Tick += timerMainAnimation_Tick;
            // 
            // timerMainTrack
            // 
            timerMainTrack.Enabled = true;
            timerMainTrack.Interval = 1000;
            timerMainTrack.Tick += timerMainTrack_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(804, 450);
            Controls.Add(tlpBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "ListenEverywhere";
            Load += Main_Load;
            tlpBar.ResumeLayout(false);
            tlpLists.ResumeLayout(false);
            tlpBarElements.ResumeLayout(false);
            tlpTrackDuration.ResumeLayout(false);
            tlpTrackDuration.PerformLayout();
            tlpLabelsTrack.ResumeLayout(false);
            tlpLabelsTrack.PerformLayout();
            tlpControlElement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)butVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)butFolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)butMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)butPrev).EndInit();
            ((System.ComponentModel.ISupportInitialize)butPlayPause).EndInit();
            ((System.ComponentModel.ISupportInitialize)butNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)butStop).EndInit();
            tlpVolumeSlider.ResumeLayout(false);
            tlpVolumeSlider.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpBar;
        private TableLayoutPanel tlpLists;
        private FlowLayoutPanel flpTrack;
        private FlowLayoutPanel flpAlbom;
        private TableLayoutPanel tlpBarElements;
        private TableLayoutPanel tlpTrackDuration;
        private Label labelDuration;
        private TableLayoutPanel tlpLabelsTrack;
        private TableLayoutPanel tlpControlElement;
        private Label labelTotTimeTrack;
        private Label labelCurTimeTrack;
        private PictureBox butVolume;
        private PictureBox butFolder;
        private PictureBox butMode;
        private PictureBox butPrev;
        private PictureBox butPlayPause;
        private PictureBox butNext;
        private PictureBox butStop;
        private TableLayoutPanel tlpVolumeSlider;
        private System.Windows.Forms.Timer timerMainAnimation;
        private System.Windows.Forms.Timer timerMainTrack;
        private Label labelVolumePercent;
        private Label labelDescriptionTrack;
    }
}