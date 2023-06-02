namespace ListenEverywhere.CustomElements
{
    partial class AudioTrackItem
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            itemArea = new TableLayoutPanel();
            authorName = new Label();
            trackName = new Label();
            pictureBox = new PictureBox();
            playButton = new Button();
            display = new System.Windows.Forms.Timer(components);
            itemArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // itemArea
            // 
            itemArea.ColumnCount = 1;
            itemArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            itemArea.Controls.Add(authorName, 0, 1);
            itemArea.Controls.Add(trackName, 0, 2);
            itemArea.Controls.Add(pictureBox, 0, 0);
            itemArea.Dock = DockStyle.Fill;
            itemArea.Location = new Point(0, 0);
            itemArea.Name = "itemArea";
            itemArea.RowCount = 3;
            itemArea.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            itemArea.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            itemArea.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            itemArea.Size = new Size(130, 160);
            itemArea.TabIndex = 1;
            // 
            // authorName
            // 
            authorName.AutoSize = true;
            authorName.Dock = DockStyle.Fill;
            authorName.Font = new Font("Open Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            authorName.ForeColor = SystemColors.ActiveCaption;
            authorName.Location = new Point(3, 112);
            authorName.Name = "authorName";
            authorName.Size = new Size(124, 24);
            authorName.TabIndex = 0;
            authorName.Text = "authorName";
            authorName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackName
            // 
            trackName.AutoSize = true;
            trackName.Dock = DockStyle.Fill;
            trackName.Font = new Font("Open Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            trackName.ForeColor = SystemColors.ActiveCaption;
            trackName.Location = new Point(3, 136);
            trackName.Name = "trackName";
            trackName.Size = new Size(124, 24);
            trackName.TabIndex = 1;
            trackName.Text = "trackName";
            trackName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.back;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(124, 106);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // playButton
            // 
            playButton.BackgroundImage = Properties.Resources.play;
            playButton.BackgroundImageLayout = ImageLayout.Zoom;
            playButton.Location = new Point(89, 80);
            playButton.Name = "playButton";
            playButton.Size = new Size(38, 33);
            playButton.TabIndex = 2;
            playButton.UseVisualStyleBackColor = true;
            playButton.Visible = false;
            playButton.Click += playButton_Click;
            // 
            // display
            // 
            display.Enabled = true;
            display.Interval = 10;
            display.Tick += AudioTrack_display_Tick;
            // 
            // AudioRightItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(playButton);
            Controls.Add(itemArea);
            Margin = new Padding(2);
            Name = "AudioRightItem";
            Size = new Size(130, 160);
            itemArea.ResumeLayout(false);
            itemArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel itemArea;
        private Label authorName;
        private Label trackName;
        private PictureBox pictureBox;
        private Button playButton;
        private System.Windows.Forms.Timer display;
    }
}
