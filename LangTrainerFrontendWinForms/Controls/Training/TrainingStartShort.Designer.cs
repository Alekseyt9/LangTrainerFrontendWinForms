namespace LangTrainerFrontendWinForms.Controls.Training
{
    partial class TrainingStartShort
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
            tableLayoutPanel1 = new TableLayoutPanel();
            _startButton = new Button();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.9375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.0625F));
            tableLayoutPanel1.Controls.Add(_startButton, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(512, 44);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // _startButton
            // 
            _startButton.Dock = DockStyle.Fill;
            _startButton.Location = new Point(332, 3);
            _startButton.Margin = new Padding(20, 3, 20, 3);
            _startButton.Name = "_startButton";
            tableLayoutPanel1.SetRowSpan(_startButton, 2);
            _startButton.Size = new Size(160, 38);
            _startButton.TabIndex = 0;
            _startButton.Text = "Start";
            _startButton.UseVisualStyleBackColor = true;
            _startButton.Click += _startButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 22);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 22);
            label2.Name = "label2";
            label2.Size = new Size(306, 22);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TrainingStartShort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TrainingStartShort";
            Size = new Size(512, 44);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button _startButton;
        private Label label1;
        private Label label2;
    }
}
