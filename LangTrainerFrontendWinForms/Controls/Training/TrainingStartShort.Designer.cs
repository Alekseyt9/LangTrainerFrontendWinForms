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
            _loginButton = new Button();
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
            tableLayoutPanel1.Controls.Add(_loginButton, 0, 0);
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
            // _loginButton
            // 
            _loginButton.BackColor = Color.LimeGreen;
            _loginButton.BackgroundImageLayout = ImageLayout.None;
            _loginButton.Dock = DockStyle.Fill;
            _loginButton.FlatStyle = FlatStyle.Flat;
            _loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            _loginButton.ForeColor = SystemColors.ButtonHighlight;
            _loginButton.Location = new Point(315, 3);
            _loginButton.Name = "_loginButton";
            tableLayoutPanel1.SetRowSpan(_loginButton, 2);
            _loginButton.Size = new Size(194, 38);
            _loginButton.TabIndex = 3;
            _loginButton.Text = "Start";
            _loginButton.UseVisualStyleBackColor = false;
            _loginButton.Click += _startButton_Click;
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
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
        private Label label1;
        private Label label2;
        private Button _loginButton;
    }
}
