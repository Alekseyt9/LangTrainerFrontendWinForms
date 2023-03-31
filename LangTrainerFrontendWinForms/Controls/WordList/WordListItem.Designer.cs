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
            splitButton1 = new Dictionary.SplitButton();
            imageList1 = new ImageList(components);
            splitButton2 = new Dictionary.SplitButton();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            progressToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            makeLearnedToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(splitButton1, 1, 0);
            tableLayoutPanel1.Controls.Add(splitButton2, 4, 0);
            tableLayoutPanel1.Controls.Add(label3, 3, 0);
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
            label1.Size = new Size(226, 41);
            label1.TabIndex = 0;
            label1.Text = "word\r\ntranslate";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitButton1
            // 
            splitButton1.Dock = DockStyle.Fill;
            splitButton1.ImageKey = "volume.png";
            splitButton1.ImageList = imageList1;
            splitButton1.Location = new Point(235, 3);
            splitButton1.Name = "splitButton1";
            splitButton1.Size = new Size(34, 35);
            splitButton1.TabIndex = 5;
            splitButton1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "bin.png");
            imageList1.Images.SetKeyName(1, "volume.png");
            // 
            // splitButton2
            // 
            splitButton2.ContextMenuStrip = contextMenuStrip1;
            splitButton2.Location = new Point(588, 3);
            splitButton2.Name = "splitButton2";
            splitButton2.Size = new Size(94, 29);
            splitButton2.TabIndex = 7;
            splitButton2.Text = "Details..";
            splitButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(275, 0);
            label2.Name = "label2";
            label2.Size = new Size(226, 41);
            label2.TabIndex = 6;
            label2.Text = "sample";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, progressToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(147, 52);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteToolStripMenuItem1 });
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(146, 24);
            deleteToolStripMenuItem.Text = "Dictionary";
            // 
            // progressToolStripMenuItem
            // 
            progressToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetToolStripMenuItem, makeLearnedToolStripMenuItem });
            progressToolStripMenuItem.Name = "progressToolStripMenuItem";
            progressToolStripMenuItem.Size = new Size(146, 24);
            progressToolStripMenuItem.Text = "Progress";
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(224, 26);
            deleteToolStripMenuItem1.Text = "Delete";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(224, 26);
            resetToolStripMenuItem.Text = "Reset";
            // 
            // makeLearnedToolStripMenuItem
            // 
            makeLearnedToolStripMenuItem.Name = "makeLearnedToolStripMenuItem";
            makeLearnedToolStripMenuItem.Size = new Size(224, 26);
            makeLearnedToolStripMenuItem.Text = "Make learned";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(507, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 40);
            label3.TabIndex = 8;
            label3.Text = "repeat in 1 day";
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
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Dictionary.SplitButton splitButton1;
        private Label label2;
        private ImageList imageList1;
        private Dictionary.SplitButton splitButton2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem progressToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem makeLearnedToolStripMenuItem;
        private Label label3;
    }
}
