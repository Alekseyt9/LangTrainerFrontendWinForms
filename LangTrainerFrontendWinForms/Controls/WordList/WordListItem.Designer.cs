namespace LangTrainerFrontendWinForms.Controls.WordList
{
    partial class WordListItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordListItem));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            _addButton = new Dictionary.SplitButton();
            imageList1 = new ImageList(components);
            splitButton1 = new Dictionary.SplitButton();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(_addButton, 3, 0);
            tableLayoutPanel1.Controls.Add(splitButton1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(687, 50);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(297, 41);
            label1.TabIndex = 0;
            label1.Text = "word\r\ntranslate";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _addButton
            // 
            _addButton.Dock = DockStyle.Fill;
            _addButton.ImageIndex = 0;
            _addButton.ImageList = imageList1;
            _addButton.Location = new Point(649, 3);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(35, 35);
            _addButton.TabIndex = 4;
            _addButton.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "bin.png");
            imageList1.Images.SetKeyName(1, "volume.png");
            // 
            // splitButton1
            // 
            splitButton1.Dock = DockStyle.Fill;
            splitButton1.ImageKey = "volume.png";
            splitButton1.ImageList = imageList1;
            splitButton1.Location = new Point(306, 3);
            splitButton1.Name = "splitButton1";
            splitButton1.Size = new Size(34, 35);
            splitButton1.TabIndex = 5;
            splitButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(346, 0);
            label2.Name = "label2";
            label2.Size = new Size(297, 41);
            label2.TabIndex = 6;
            label2.Text = "sample";
            // 
            // WordListItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Name = "WordListItem";
            Size = new Size(687, 50);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Dictionary.SplitButton _addButton;
        private Dictionary.SplitButton splitButton1;
        private Label label2;
        private ImageList imageList1;
    }
}
