﻿namespace LangTrainerFrontendWinForms.Controls
{
    partial class SentenceControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentenceControl));
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            _lang = new ComboBox();
            _text = new TextBox();
            _buttonLoad = new Button();
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(742, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sentence";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(_lang, 3, 0);
            tableLayoutPanel1.Controls.Add(_text, 1, 0);
            tableLayoutPanel1.Controls.Add(_buttonLoad, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 27);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(736, 87);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 39);
            label1.TabIndex = 0;
            label1.Text = "Text:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(348, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 39);
            label2.TabIndex = 1;
            label2.Text = "Language:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _lang
            // 
            _lang.Dock = DockStyle.Fill;
            _lang.FormattingEnabled = true;
            _lang.Items.AddRange(new object[] { "english", "france", "german", "italian" });
            _lang.Location = new Point(448, 3);
            _lang.Name = "_lang";
            _lang.Size = new Size(239, 33);
            _lang.TabIndex = 2;
            // 
            // _text
            // 
            _text.Dock = DockStyle.Fill;
            _text.Location = new Point(103, 3);
            _text.Name = "_text";
            _text.Size = new Size(239, 31);
            _text.TabIndex = 3;
            // 
            // _buttonLoad
            // 
            _buttonLoad.Dock = DockStyle.Fill;
            _buttonLoad.ImageIndex = 0;
            _buttonLoad.ImageList = imageList1;
            _buttonLoad.Location = new Point(693, 3);
            _buttonLoad.Name = "_buttonLoad";
            _buttonLoad.Size = new Size(40, 33);
            _buttonLoad.TabIndex = 4;
            _buttonLoad.UseVisualStyleBackColor = true;
            _buttonLoad.Click += _buttonLoad_Click;
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
            // SentenceControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "SentenceControl";
            Size = new Size(742, 117);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private ComboBox _lang;
        private TextBox _text;
        private Button _buttonLoad;
        private ImageList imageList1;
    }
}
