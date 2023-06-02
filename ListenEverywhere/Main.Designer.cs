namespace ListenEverywhere
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            tlpBar = new TableLayoutPanel();
            tlpLists = new TableLayoutPanel();
            flpTrack = new FlowLayoutPanel();
            flpAlbom = new FlowLayoutPanel();
            tlpBarElements = new TableLayoutPanel();
            tlpTrackDuration = new TableLayoutPanel();
            labelDuration = new Label();
            tlpLabelsTrack = new TableLayoutPanel();
            totTimeTrack = new Label();
            descriptionTrack = new Label();
            curTimeTrack = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            butVolume = new PictureBox();
            butFolder = new PictureBox();
            butMode = new PictureBox();
            butPrev = new PictureBox();
            butPlayPause = new PictureBox();
            butNext = new PictureBox();
            butStop = new PictureBox();
            tlpVolumeSlider = new TableLayoutPanel();
            timerMain = new System.Windows.Forms.Timer(components);
            tlpBar.SuspendLayout();
            tlpLists.SuspendLayout();
            tlpBarElements.SuspendLayout();
            tlpTrackDuration.SuspendLayout();
            tlpLabelsTrack.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)butVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butFolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butPrev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butPlayPause).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)butStop).BeginInit();
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
            tlpBar.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tlpBar.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpBar.Size = new Size(800, 450);
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
            tlpLists.Size = new Size(788, 324);
            tlpLists.TabIndex = 0;
            // 
            // flpTrack
            // 
            flpTrack.AutoScroll = true;
            flpTrack.Dock = DockStyle.Fill;
            flpTrack.Location = new Point(236, 0);
            flpTrack.Margin = new Padding(0);
            flpTrack.Name = "flpTrack";
            flpTrack.Size = new Size(552, 324);
            flpTrack.TabIndex = 0;
            // 
            // flpAlbom
            // 
            flpAlbom.AutoScroll = true;
            flpAlbom.Dock = DockStyle.Fill;
            flpAlbom.Location = new Point(0, 0);
            flpAlbom.Margin = new Padding(0);
            flpAlbom.Name = "flpAlbom";
            flpAlbom.Size = new Size(236, 324);
            flpAlbom.TabIndex = 1;
            // 
            // tlpBarElements
            // 
            tlpBarElements.ColumnCount = 1;
            tlpBarElements.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBarElements.Controls.Add(tlpTrackDuration, 0, 0);
            tlpBarElements.Controls.Add(tlpLabelsTrack, 0, 1);
            tlpBarElements.Controls.Add(tableLayoutPanel1, 0, 2);
            tlpBarElements.Dock = DockStyle.Fill;
            tlpBarElements.Location = new Point(3, 336);
            tlpBarElements.Margin = new Padding(0);
            tlpBarElements.Name = "tlpBarElements";
            tlpBarElements.RowCount = 3;
            tlpBarElements.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tlpBarElements.RowStyles.Add(new RowStyle(SizeType.Percent, 44.4444427F));
            tlpBarElements.RowStyles.Add(new RowStyle(SizeType.Percent, 44.4444427F));
            tlpBarElements.Size = new Size(794, 111);
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
            tlpTrackDuration.Size = new Size(794, 12);
            tlpTrackDuration.TabIndex = 0;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.BackColor = Color.Green;
            labelDuration.Dock = DockStyle.Fill;
            labelDuration.ForeColor = Color.White;
            labelDuration.Location = new Point(3, 0);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(1, 12);
            labelDuration.TabIndex = 0;
            // 
            // tlpLabelsTrack
            // 
            tlpLabelsTrack.ColumnCount = 3;
            tlpLabelsTrack.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpLabelsTrack.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpLabelsTrack.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpLabelsTrack.Controls.Add(totTimeTrack, 2, 0);
            tlpLabelsTrack.Controls.Add(descriptionTrack, 1, 0);
            tlpLabelsTrack.Controls.Add(curTimeTrack, 0, 0);
            tlpLabelsTrack.Dock = DockStyle.Fill;
            tlpLabelsTrack.Location = new Point(3, 15);
            tlpLabelsTrack.Name = "tlpLabelsTrack";
            tlpLabelsTrack.RowCount = 1;
            tlpLabelsTrack.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLabelsTrack.Size = new Size(788, 43);
            tlpLabelsTrack.TabIndex = 1;
            // 
            // totTimeTrack
            // 
            totTimeTrack.AutoSize = true;
            totTimeTrack.Dock = DockStyle.Fill;
            totTimeTrack.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            totTimeTrack.ForeColor = SystemColors.ActiveCaption;
            totTimeTrack.Location = new Point(632, 0);
            totTimeTrack.Name = "totTimeTrack";
            totTimeTrack.Size = new Size(153, 43);
            totTimeTrack.TabIndex = 0;
            totTimeTrack.Text = "time";
            totTimeTrack.TextAlign = ContentAlignment.TopRight;
            // 
            // descriptionTrack
            // 
            descriptionTrack.AutoSize = true;
            descriptionTrack.Dock = DockStyle.Fill;
            descriptionTrack.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTrack.ForeColor = SystemColors.ActiveCaption;
            descriptionTrack.Location = new Point(160, 0);
            descriptionTrack.Name = "descriptionTrack";
            descriptionTrack.Size = new Size(466, 43);
            descriptionTrack.TabIndex = 1;
            descriptionTrack.Text = "descriptionTrack";
            descriptionTrack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // curTimeTrack
            // 
            curTimeTrack.AutoSize = true;
            curTimeTrack.Dock = DockStyle.Fill;
            curTimeTrack.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            curTimeTrack.ForeColor = SystemColors.ActiveCaption;
            curTimeTrack.Location = new Point(3, 0);
            curTimeTrack.Name = "curTimeTrack";
            curTimeTrack.Size = new Size(151, 43);
            curTimeTrack.TabIndex = 2;
            curTimeTrack.Text = "time";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(butVolume, 1, 0);
            tableLayoutPanel1.Controls.Add(butFolder, 2, 0);
            tableLayoutPanel1.Controls.Add(butMode, 3, 0);
            tableLayoutPanel1.Controls.Add(butPrev, 4, 0);
            tableLayoutPanel1.Controls.Add(butPlayPause, 5, 0);
            tableLayoutPanel1.Controls.Add(butNext, 6, 0);
            tableLayoutPanel1.Controls.Add(butStop, 7, 0);
            tableLayoutPanel1.Controls.Add(tlpVolumeSlider, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(788, 44);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // butVolume
            // 
            butVolume.Anchor = AnchorStyles.Bottom;
            butVolume.Image = Properties.Resources.volumeon;
            butVolume.Location = new Point(250, 9);
            butVolume.Margin = new Padding(0);
            butVolume.Name = "butVolume";
            butVolume.Size = new Size(50, 35);
            butVolume.SizeMode = PictureBoxSizeMode.Zoom;
            butVolume.TabIndex = 0;
            butVolume.TabStop = false;
            // 
            // butFolder
            // 
            butFolder.Anchor = AnchorStyles.Bottom;
            butFolder.Image = Properties.Resources.folder;
            butFolder.Location = new Point(328, 9);
            butFolder.Margin = new Padding(0);
            butFolder.Name = "butFolder";
            butFolder.Size = new Size(50, 35);
            butFolder.SizeMode = PictureBoxSizeMode.Zoom;
            butFolder.TabIndex = 1;
            butFolder.TabStop = false;
            // 
            // butMode
            // 
            butMode.Anchor = AnchorStyles.Bottom;
            butMode.Image = Properties.Resources.random;
            butMode.Location = new Point(406, 9);
            butMode.Margin = new Padding(0);
            butMode.Name = "butMode";
            butMode.Size = new Size(50, 35);
            butMode.SizeMode = PictureBoxSizeMode.Zoom;
            butMode.TabIndex = 2;
            butMode.TabStop = false;
            // 
            // butPrev
            // 
            butPrev.Anchor = AnchorStyles.Bottom;
            butPrev.Image = Properties.Resources.previous;
            butPrev.Location = new Point(484, 9);
            butPrev.Margin = new Padding(0);
            butPrev.Name = "butPrev";
            butPrev.Size = new Size(50, 35);
            butPrev.SizeMode = PictureBoxSizeMode.Zoom;
            butPrev.TabIndex = 3;
            butPrev.TabStop = false;
            // 
            // butPlayPause
            // 
            butPlayPause.Anchor = AnchorStyles.Bottom;
            butPlayPause.Image = Properties.Resources.play;
            butPlayPause.Location = new Point(562, 9);
            butPlayPause.Margin = new Padding(0);
            butPlayPause.Name = "butPlayPause";
            butPlayPause.Size = new Size(50, 35);
            butPlayPause.SizeMode = PictureBoxSizeMode.Zoom;
            butPlayPause.TabIndex = 4;
            butPlayPause.TabStop = false;
            // 
            // butNext
            // 
            butNext.Anchor = AnchorStyles.Bottom;
            butNext.Image = Properties.Resources.next;
            butNext.Location = new Point(640, 9);
            butNext.Margin = new Padding(0);
            butNext.Name = "butNext";
            butNext.Size = new Size(50, 35);
            butNext.SizeMode = PictureBoxSizeMode.Zoom;
            butNext.TabIndex = 5;
            butNext.TabStop = false;
            // 
            // butStop
            // 
            butStop.Anchor = AnchorStyles.Bottom;
            butStop.Image = Properties.Resources.stop;
            butStop.Location = new Point(721, 9);
            butStop.Margin = new Padding(0);
            butStop.Name = "butStop";
            butStop.Size = new Size(50, 35);
            butStop.SizeMode = PictureBoxSizeMode.Zoom;
            butStop.TabIndex = 6;
            butStop.TabStop = false;
            // 
            // tlpVolumeSlider
            // 
            tlpVolumeSlider.ColumnCount = 2;
            tlpVolumeSlider.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpVolumeSlider.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpVolumeSlider.Dock = DockStyle.Fill;
            tlpVolumeSlider.Location = new Point(0, 0);
            tlpVolumeSlider.Margin = new Padding(0);
            tlpVolumeSlider.Name = "tlpVolumeSlider";
            tlpVolumeSlider.RowCount = 1;
            tlpVolumeSlider.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpVolumeSlider.Size = new Size(236, 44);
            tlpVolumeSlider.TabIndex = 7;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formMain";
            Text = "ListenEverywhere";
            tlpBar.ResumeLayout(false);
            tlpLists.ResumeLayout(false);
            tlpBarElements.ResumeLayout(false);
            tlpTrackDuration.ResumeLayout(false);
            tlpTrackDuration.PerformLayout();
            tlpLabelsTrack.ResumeLayout(false);
            tlpLabelsTrack.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)butVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)butFolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)butMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)butPrev).EndInit();
            ((System.ComponentModel.ISupportInitialize)butPlayPause).EndInit();
            ((System.ComponentModel.ISupportInitialize)butNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)butStop).EndInit();
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label totTimeTrack;
        private Label descriptionTrack;
        private Label curTimeTrack;
        private PictureBox butVolume;
        private PictureBox butFolder;
        private PictureBox butMode;
        private PictureBox butPrev;
        private PictureBox butPlayPause;
        private PictureBox butNext;
        private PictureBox butStop;
        private TableLayoutPanel tlpVolumeSlider;
        private System.Windows.Forms.Timer timerMain;
    }
}