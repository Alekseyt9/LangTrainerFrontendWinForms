namespace LangTrainerFrontendWinForms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            exStartControl1 = new Controls.Training.ExStart.ExStartControl();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            tabControl2 = new TabControl();
            tabPage7 = new TabPage();
            tabPage6 = new TabPage();
            tabPage8 = new TabPage();
            comboBox1 = new ComboBox();
            tabPage9 = new TabPage();
            sentenceEditControl1 = new Controls.SentenceEditControl();
            imageList1 = new ImageList(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage8.SuspendLayout();
            tabPage9.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(186, 56);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(exStartControl1);
            tabPage1.Location = new Point(4, 94);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(178, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Exercize1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // exStartControl1
            // 
            exStartControl1.Dock = DockStyle.Fill;
            exStartControl1.Location = new Point(3, 3);
            exStartControl1.Name = "exStartControl1";
            exStartControl1.Size = new Size(172, 0);
            exStartControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1052, 510);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Exercize2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1052, 510);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Exercize3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1052, 510);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Exercize4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1052, 510);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Resut";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(186, 56);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage7);
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Controls.Add(tabPage8);
            tabControl2.Controls.Add(tabPage9);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1074, 592);
            tabControl2.TabIndex = 3;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 34);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1066, 554);
            tabPage7.TabIndex = 1;
            tabPage7.Text = "Login";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(tableLayoutPanel3);
            tabPage6.Location = new Point(4, 34);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(192, 62);
            tabPage6.TabIndex = 0;
            tabPage6.Text = "Trainer";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(comboBox1);
            tabPage8.Location = new Point(4, 34);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(192, 62);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "Dictionary";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 33);
            comboBox1.TabIndex = 1;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(sentenceEditControl1);
            tabPage9.Location = new Point(4, 34);
            tabPage9.Name = "tabPage9";
            tabPage9.Size = new Size(1066, 554);
            tabPage9.TabIndex = 3;
            tabPage9.Text = "EditSentence";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // sentenceEditControl1
            // 
            sentenceEditControl1.Dock = DockStyle.Fill;
            sentenceEditControl1.Location = new Point(0, 0);
            sentenceEditControl1.Margin = new Padding(0);
            sentenceEditControl1.Name = "sentenceEditControl1";
            sentenceEditControl1.Size = new Size(1066, 554);
            sentenceEditControl1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "reload.png");
            imageList1.Images.SetKeyName(1, "boss.png");
            imageList1.Images.SetKeyName(2, "plus.png");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 592);
            Controls.Add(tabControl2);
            Name = "FormMain";
            Text = "LangTrainer";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage8.ResumeLayout(false);
            tabPage9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel3;
        private TabPage tabPage5;
        private TabControl tabControl2;
        private TabPage tabPage7;
        private TabPage tabPage6;
        private TabPage tabPage8;
        private ComboBox comboBox1;
        private TabPage tabPage9;
        private ImageList imageList1;
        private Controls.SentenceEditControl sentenceEditControl1;
        private Controls.Training.ExStart.ExStartControl exStartControl1;
    }
}