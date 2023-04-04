namespace LangTrainerFrontendWinForms.Controls.WordList
{
    partial class WordListItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordListItemControl));
            tableLayoutPanel1 = new TableLayoutPanel();
            _buttonSound = new Dictionary.SplitButton();
            imageList1 = new ImageList(components);
            _buttonDetails = new Dictionary.SplitButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            progressToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            makeLearnedToolStripMenuItem = new ToolStripMenuItem();
            _labelTrainingState = new Label();
            _labelSample = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            _labelWord = new Label();
            _labelTranslate = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(_buttonSound, 1, 0);
            tableLayoutPanel1.Controls.Add(_buttonDetails, 4, 0);
            tableLayoutPanel1.Controls.Add(_labelTrainingState, 3, 0);
            tableLayoutPanel1.Controls.Add(_labelSample, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(687, 50);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // _buttonSound
            // 
            _buttonSound.Dock = DockStyle.Fill;
            _buttonSound.ImageKey = "volume.png";
            _buttonSound.ImageList = imageList1;
            _buttonSound.Location = new Point(235, 3);
            _buttonSound.Name = "_buttonSound";
            _buttonSound.Size = new Size(34, 35);
            _buttonSound.TabIndex = 5;
            _buttonSound.UseVisualStyleBackColor = true;
            _buttonSound.Click += _buttonSound_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "bin.png");
            imageList1.Images.SetKeyName(1, "volume.png");
            // 
            // _buttonDetails
            // 
            _buttonDetails.Location = new Point(588, 3);
            _buttonDetails.Menu = contextMenuStrip1;
            _buttonDetails.Name = "_buttonDetails";
            _buttonDetails.Size = new Size(94, 29);
            _buttonDetails.TabIndex = 7;
            _buttonDetails.Text = "Details..";
            _buttonDetails.UseVisualStyleBackColor = true;
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
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(136, 26);
            deleteToolStripMenuItem1.Text = "Delete";
            // 
            // progressToolStripMenuItem
            // 
            progressToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetToolStripMenuItem, makeLearnedToolStripMenuItem });
            progressToolStripMenuItem.Name = "progressToolStripMenuItem";
            progressToolStripMenuItem.Size = new Size(146, 24);
            progressToolStripMenuItem.Text = "Progress";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(182, 26);
            resetToolStripMenuItem.Text = "Reset";
            // 
            // makeLearnedToolStripMenuItem
            // 
            makeLearnedToolStripMenuItem.Name = "makeLearnedToolStripMenuItem";
            makeLearnedToolStripMenuItem.Size = new Size(182, 26);
            makeLearnedToolStripMenuItem.Text = "Make learned";
            // 
            // _labelTrainingState
            // 
            _labelTrainingState.AutoSize = true;
            _labelTrainingState.Dock = DockStyle.Fill;
            _labelTrainingState.Location = new Point(507, 0);
            _labelTrainingState.Name = "_labelTrainingState";
            _labelTrainingState.Size = new Size(75, 41);
            _labelTrainingState.TabIndex = 8;
            _labelTrainingState.Text = "repeat in 1 day";
            // 
            // _labelSample
            // 
            _labelSample.AutoSize = true;
            _labelSample.Dock = DockStyle.Fill;
            _labelSample.Location = new Point(275, 0);
            _labelSample.Name = "_labelSample";
            _labelSample.Size = new Size(226, 41);
            _labelSample.TabIndex = 9;
            _labelSample.Text = "Sample";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(_labelWord, 0, 0);
            tableLayoutPanel2.Controls.Add(_labelTranslate, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(232, 41);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // _labelWord
            // 
            _labelWord.AutoSize = true;
            _labelWord.Dock = DockStyle.Fill;
            _labelWord.Location = new Point(3, 0);
            _labelWord.Name = "_labelWord";
            _labelWord.Size = new Size(226, 20);
            _labelWord.TabIndex = 0;
            _labelWord.Text = "label1";
            // 
            // _labelTranslate
            // 
            _labelTranslate.AutoSize = true;
            _labelTranslate.Dock = DockStyle.Fill;
            _labelTranslate.Location = new Point(3, 20);
            _labelTranslate.Name = "_labelTranslate";
            _labelTranslate.Size = new Size(226, 21);
            _labelTranslate.TabIndex = 1;
            _labelTranslate.Text = "label5";
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
            // WordListItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Name = "WordListItemControl";
            Size = new Size(687, 50);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label _labelTrainingState;
        private Dictionary.SplitButton _buttonSound;
        private Label label2;
        private ImageList imageList1;
        private Dictionary.SplitButton _buttonDetails;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem progressToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem makeLearnedToolStripMenuItem;
        private Label label3;
        private Label _labelSample;
        private TableLayoutPanel tableLayoutPanel2;
        private Label _labelWord;
        private Label _labelTranslate;
    }
}
