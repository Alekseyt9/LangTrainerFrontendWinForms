namespace LangTrainerFrontendWinForms.Controls
{
    partial class SentenceEditControl
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
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            button10 = new Button();
            button11 = new Button();
            tableLayoutPanel10 = new TableLayoutPanel();
            translatesControl1 = new TranslatesControl();
            samplesControl1 = new SamplesControl();
            soundsControl1 = new SoundsControl();
            sentenceControl1 = new SentenceControl();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 0, 1);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel8.Size = new Size(715, 562);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            tableLayoutPanel9.Controls.Add(button10, 1, 0);
            tableLayoutPanel9.Controls.Add(button11, 2, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 518);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(715, 44);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(428, 3);
            button10.Name = "button10";
            button10.Size = new Size(139, 38);
            button10.TabIndex = 0;
            button10.Text = "OK";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(573, 3);
            button11.Name = "button11";
            button11.Size = new Size(139, 38);
            button11.TabIndex = 1;
            button11.Text = "Cancel";
            button11.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(translatesControl1, 0, 2);
            tableLayoutPanel10.Controls.Add(samplesControl1, 0, 3);
            tableLayoutPanel10.Controls.Add(soundsControl1, 0, 1);
            tableLayoutPanel10.Controls.Add(sentenceControl1, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 6;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle());
            tableLayoutPanel10.Size = new Size(709, 512);
            tableLayoutPanel10.TabIndex = 1;
            // 
            // translatesControl1
            // 
            translatesControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            translatesControl1.Dock = DockStyle.Fill;
            translatesControl1.Location = new Point(0, 174);
            translatesControl1.Margin = new Padding(0);
            translatesControl1.Name = "translatesControl1";
            translatesControl1.Size = new Size(709, 152);
            translatesControl1.TabIndex = 10;
            // 
            // samplesControl1
            // 
            samplesControl1.Dock = DockStyle.Fill;
            samplesControl1.Location = new Point(0, 326);
            samplesControl1.Margin = new Padding(0);
            samplesControl1.Name = "samplesControl1";
            samplesControl1.Size = new Size(709, 152);
            samplesControl1.TabIndex = 11;
            // 
            // soundsControl1
            // 
            soundsControl1.Dock = DockStyle.Fill;
            soundsControl1.Location = new Point(0, 87);
            soundsControl1.Margin = new Padding(0);
            soundsControl1.Name = "soundsControl1";
            soundsControl1.Size = new Size(709, 87);
            soundsControl1.TabIndex = 12;
            // 
            // sentenceControl1
            // 
            sentenceControl1.Dock = DockStyle.Fill;
            sentenceControl1.Location = new Point(3, 3);
            sentenceControl1.Name = "sentenceControl1";
            sentenceControl1.Size = new Size(703, 81);
            sentenceControl1.TabIndex = 13;
            // 
            // SentenceEditControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel8);
            Name = "SentenceEditControl";
            Size = new Size(715, 562);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private Button button10;
        private Button button11;
        private TableLayoutPanel tableLayoutPanel10;
        private TranslatesControl translatesControl1;
        private SamplesControl samplesControl1;
        private SoundsControl soundsControl1;
        private SentenceControl sentenceControl1;
    }
}
