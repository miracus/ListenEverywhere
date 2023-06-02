namespace ListenEverywhere.CustomElements
{
    partial class AudioAlbomsItem
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
            description = new Label();
            tlpListArea = new TableLayoutPanel();
            pictureBox = new PictureBox();
            tlpLabels = new TableLayoutPanel();
            albom = new Label();
            tlpListArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tlpLabels.SuspendLayout();
            SuspendLayout();
            // 
            // description
            // 
            description.AutoSize = true;
            description.Dock = DockStyle.Fill;
            description.Font = new Font("Microsoft Himalaya", 12F, FontStyle.Regular, GraphicsUnit.Point);
            description.ForeColor = SystemColors.ActiveCaption;
            description.Location = new Point(3, 27);
            description.Name = "description";
            description.Size = new Size(128, 27);
            description.TabIndex = 1;
            description.Text = "description";
            description.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpListArea
            // 
            tlpListArea.ColumnCount = 2;
            tlpListArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpListArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpListArea.Controls.Add(pictureBox, 0, 0);
            tlpListArea.Controls.Add(tlpLabels, 1, 0);
            tlpListArea.Dock = DockStyle.Fill;
            tlpListArea.Location = new Point(0, 0);
            tlpListArea.Name = "tlpListArea";
            tlpListArea.RowCount = 1;
            tlpListArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpListArea.Size = new Size(200, 60);
            tlpListArea.TabIndex = 1;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Properties.Resources.back;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(54, 54);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // tlpLabels
            // 
            tlpLabels.ColumnCount = 1;
            tlpLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLabels.Controls.Add(albom, 0, 0);
            tlpLabels.Controls.Add(description, 0, 1);
            tlpLabels.Dock = DockStyle.Fill;
            tlpLabels.Location = new Point(63, 3);
            tlpLabels.Name = "tlpLabels";
            tlpLabels.RowCount = 2;
            tlpLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLabels.Size = new Size(134, 54);
            tlpLabels.TabIndex = 1;
            // 
            // albom
            // 
            albom.AutoSize = true;
            albom.Dock = DockStyle.Fill;
            albom.Font = new Font("Microsoft Himalaya", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            albom.ForeColor = SystemColors.ActiveCaption;
            albom.Location = new Point(3, 0);
            albom.Name = "albom";
            albom.Size = new Size(128, 27);
            albom.TabIndex = 0;
            albom.Text = "albom";
            albom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AudioLeftItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            Controls.Add(tlpListArea);
            Margin = new Padding(1);
            Name = "AudioLeftItem";
            Size = new Size(200, 60);
            tlpListArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tlpLabels.ResumeLayout(false);
            tlpLabels.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label description;
        private TableLayoutPanel tlpListArea;
        private PictureBox pictureBox;
        private TableLayoutPanel tlpLabels;
        private Label albom;
    }
}
