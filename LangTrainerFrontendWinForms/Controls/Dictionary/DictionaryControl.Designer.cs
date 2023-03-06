namespace LangTrainerFrontendWinForms.Controls
{
    partial class DictionaryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictionaryControl));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            _itemsTableLayout = new TableLayoutPanel();
            addWordItem1 = new Dictionary.Items.AddWordItemControl();
            wordNotFoundItem1 = new Dictionary.Items.WordNotFoundItemControl();
            _searchText = new TextBox();
            imageList1 = new ImageList(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            _itemsTableLayout.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(_searchText, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.883721F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.11628F));
            tableLayoutPanel1.Size = new Size(556, 344);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(_itemsTableLayout);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 304);
            panel1.TabIndex = 4;
            // 
            // _itemsTableLayout
            // 
            _itemsTableLayout.ColumnCount = 1;
            _itemsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _itemsTableLayout.Controls.Add(addWordItem1, 0, 1);
            _itemsTableLayout.Controls.Add(wordNotFoundItem1, 0, 0);
            _itemsTableLayout.Dock = DockStyle.Fill;
            _itemsTableLayout.Location = new Point(0, 0);
            _itemsTableLayout.Name = "_itemsTableLayout";
            _itemsTableLayout.RowCount = 3;
            _itemsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            _itemsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            _itemsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _itemsTableLayout.Size = new Size(550, 304);
            _itemsTableLayout.TabIndex = 0;
            // 
            // addWordItem1
            // 
            addWordItem1.Dock = DockStyle.Fill;
            addWordItem1.Location = new Point(3, 43);
            addWordItem1.Name = "addWordItem1";
            addWordItem1.Size = new Size(544, 34);
            addWordItem1.TabIndex = 0;
            // 
            // wordNotFoundItem1
            // 
            wordNotFoundItem1.Dock = DockStyle.Fill;
            wordNotFoundItem1.Location = new Point(3, 3);
            wordNotFoundItem1.Name = "wordNotFoundItem1";
            wordNotFoundItem1.Size = new Size(544, 34);
            wordNotFoundItem1.TabIndex = 1;
            // 
            // _searchText
            // 
            _searchText.Dock = DockStyle.Fill;
            _searchText.Location = new Point(3, 3);
            _searchText.Name = "_searchText";
            _searchText.Size = new Size(550, 27);
            _searchText.TabIndex = 5;
            _searchText.TextChanged += _searchTextTextChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "reload.png");
            imageList1.Images.SetKeyName(1, "boss.png");
            imageList1.Images.SetKeyName(2, "plus.png");
            imageList1.Images.SetKeyName(3, "plus1.png");
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 276);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 11, 0);
            statusStrip1.Size = new Size(556, 27);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(63, 21);
            toolStripStatusLabel1.Text = "Loading";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.MarqueeAnimationSpeed = 50;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(80, 19);
            toolStripProgressBar1.Step = 1;
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            // 
            // DictionaryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "DictionaryControl";
            Size = new Size(556, 303);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            _itemsTableLayout.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private ImageList imageList1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private Panel panel1;
        private TableLayoutPanel _itemsTableLayout;
        private Dictionary.Items.AddWordItemControl addWordItem1;
        private Dictionary.Items.WordNotFoundItemControl wordNotFoundItem1;
        private TextBox _searchText;
    }
}
