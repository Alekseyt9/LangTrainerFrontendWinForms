namespace LangTrainerFrontendWinForms.Controls.Training.ExStart.Labels
{
    partial class LabelRepeat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            _labelHeader = new Label();
            _labelWords = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 237, 240);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(20);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 170);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5823746F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.4176254F));
            tableLayoutPanel2.Controls.Add(_labelHeader, 1, 0);
            tableLayoutPanel2.Controls.Add(_labelWords, 1, 1);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(783, 170);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // _labelHeader
            // 
            _labelHeader.AutoSize = true;
            _labelHeader.Dock = DockStyle.Fill;
            _labelHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            _labelHeader.Location = new Point(148, 0);
            _labelHeader.Name = "_labelHeader";
            _labelHeader.Size = new Size(632, 85);
            _labelHeader.TabIndex = 0;
            _labelHeader.Text = "111 words urgently repeat";
            _labelHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _labelWords
            // 
            _labelWords.AutoSize = true;
            _labelWords.Dock = DockStyle.Fill;
            _labelWords.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            _labelWords.Location = new Point(148, 85);
            _labelWords.Name = "_labelWords";
            _labelWords.Size = new Size(632, 85);
            _labelWords.TabIndex = 1;
            _labelWords.Text = "word1 word2 word3";
            _labelWords.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel2.SetRowSpan(pictureBox1, 2);
            pictureBox1.Size = new Size(139, 164);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LabelRepeat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "LabelRepeat";
            Size = new Size(783, 170);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label _labelHeader;
        private Label _labelWords;
        private PictureBox pictureBox1;
    }
}
