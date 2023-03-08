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
            groupBox1 = new GroupBox();
            _itemsTableLayout = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            _langFilterCombo = new ComboBox();
            _trLangFilterCombo = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            _clearButton = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            _searchText = new TextBox();
            _progressBar = new ProgressBar();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(_progressBar, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(699, 383);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 300);
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
            groupBox1.Size = new Size(693, 300);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "SearchResult";
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
            _itemsTableLayout.Size = new Size(687, 274);
            _itemsTableLayout.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 152F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(_langFilterCombo, 1, 0);
            tableLayoutPanel2.Controls.Add(_trLangFilterCombo, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 34);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(699, 35);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 35);
            label1.TabIndex = 0;
            label1.Text = "Language:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(323, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 35);
            label2.TabIndex = 1;
            label2.Text = "Translate language:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _langFilterCombo
            // 
            _langFilterCombo.Dock = DockStyle.Fill;
            _langFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            _langFilterCombo.FormattingEnabled = true;
            _langFilterCombo.Location = new Point(97, 3);
            _langFilterCombo.Name = "_langFilterCombo";
            _langFilterCombo.Size = new Size(220, 28);
            _langFilterCombo.TabIndex = 2;
            // 
            // _trLangFilterCombo
            // 
            _trLangFilterCombo.Dock = DockStyle.Fill;
            _trLangFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            _trLangFilterCombo.FormattingEnabled = true;
            _trLangFilterCombo.Location = new Point(475, 3);
            _trLangFilterCombo.Name = "_trLangFilterCombo";
            _trLangFilterCombo.Size = new Size(221, 28);
            _trLangFilterCombo.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel3.Controls.Add(_clearButton, 2, 0);
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(_searchText, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(699, 34);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // _clearButton
            // 
            _clearButton.Dock = DockStyle.Fill;
            _clearButton.ImageIndex = 5;
            _clearButton.ImageList = imageList1;
            _clearButton.Location = new Point(668, 2);
            _clearButton.Margin = new Padding(2);
            _clearButton.Name = "_clearButton";
            _clearButton.Size = new Size(29, 30);
            _clearButton.TabIndex = 5;
            _clearButton.UseVisualStyleBackColor = true;
            _clearButton.Click += clearButtonClick;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.magnifying_glass;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // _searchText
            // 
            _searchText.Dock = DockStyle.Fill;
            _searchText.Location = new Point(36, 3);
            _searchText.Name = "_searchText";
            _searchText.Size = new Size(627, 27);
            _searchText.TabIndex = 1;
            _searchText.TextChanged += searchTextTextChanged;
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
            // DictionaryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "DictionaryControl";
            Size = new Size(699, 383);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private AddWordItemControl addWordItem1;
        private WordNotFoundItemControl wordNotFoundItem1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private ComboBox _langFilterCombo;
        private ComboBox _trLangFilterCombo;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox1;
        private TextBox _searchText;
        private Button _clearButton;
        private ProgressBar _progressBar;
    }
}
