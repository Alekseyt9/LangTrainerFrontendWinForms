namespace LangTrainerFrontendWinForms.Controls.Training.Ex4
{
    partial class Ex4Control
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
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 394F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label1, 1, 1);
            tableLayoutPanel5.Controls.Add(textBox1, 1, 2);
            tableLayoutPanel5.Controls.Add(button5, 1, 4);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(750, 419);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(180, 105);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(390, 65);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(181, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 52);
            textBox1.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Dock = DockStyle.Right;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(452, 267);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(120, 47);
            button5.TabIndex = 4;
            button5.Text = "Next";
            button5.UseVisualStyleBackColor = false;
            // 
            // Ex4Control
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel5);
            Name = "Ex4Control";
            Size = new Size(750, 419);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private TextBox textBox1;
        private Button button5;
    }
}
