namespace LangTrainerFrontendWinForms.Controls
{
    partial class DictionaryPageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictionaryPageControl));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            _itemsTableLayout = new TableLayoutPanel();
            _progressBar = new ProgressBar();
            _searchControl = new SearchControl();
            imageList1 = new ImageList(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(_progressBar, 0, 2);
            tableLayoutPanel1.Controls.Add(_searchControl, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(699, 383);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 329);
            panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(_itemsTableLayout);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(693, 329);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // _itemsTableLayout
            // 
            _itemsTableLayout.ColumnCount = 1;
            _itemsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _itemsTableLayout.Dock = DockStyle.Fill;
            _itemsTableLayout.Location = new Point(3, 23);
            _itemsTableLayout.Margin = new Padding(0);
            _itemsTableLayout.Name = "_itemsTableLayout";
            _itemsTableLayout.RowCount = 3;
            _itemsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            _itemsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            _itemsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _itemsTableLayout.Size = new Size(687, 303);
            _itemsTableLayout.TabIndex = 0;
            // 
            // _progressBar
            // 
            _progressBar.Dock = DockStyle.Fill;
            _progressBar.Location = new Point(3, 378);
            _progressBar.MarqueeAnimationSpeed = 30;
            _progressBar.Name = "_progressBar";
            _progressBar.Size = new Size(693, 2);
            _progressBar.Step = 1;
            _progressBar.Style = ProgressBarStyle.Continuous;
            _progressBar.TabIndex = 8;
            // 
            // _searchControl
            // 
            _searchControl.Dock = DockStyle.Fill;
            _searchControl.Location = new Point(3, 3);
            _searchControl.Name = "_searchControl";
            _searchControl.Size = new Size(693, 34);
            _searchControl.TabIndex = 10;
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
            imageList1.Images.SetKeyName(4, "magnifying-glass.png");
            imageList1.Images.SetKeyName(5, "clear.png");
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 356);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 11, 0);
            statusStrip1.Size = new Size(699, 27);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.Visible = false;
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
            // DictionaryPageControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "DictionaryPageControl";
            Size = new Size(699, 383);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
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
        private WordInDictionaryItemControl addWordItem1;
        private WordNotFoundItemControl wordNotFoundItem1;
        private GroupBox groupBox1;
        private ProgressBar _progressBar;
        private SearchControl _searchControl;
    }
}
