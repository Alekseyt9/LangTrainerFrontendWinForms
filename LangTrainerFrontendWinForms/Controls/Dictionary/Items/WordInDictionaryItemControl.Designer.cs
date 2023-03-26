namespace LangTrainerFrontendWinForms.Controls
{
    partial class WordInDictionaryItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordInDictionaryItemControl));
            tableLayoutPanel1 = new TableLayoutPanel();
            _soundButton = new Dictionary.SplitButton();
            imageList1 = new ImageList(components);
            label2 = new Label();
            _wordText = new TextBox();
            _translateCombo = new ComboBox();
            _addButton = new Dictionary.SplitButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(_soundButton, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(_wordText, 1, 0);
            tableLayoutPanel1.Controls.Add(_translateCombo, 3, 0);
            tableLayoutPanel1.Controls.Add(_addButton, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(581, 44);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // _soundButton
            // 
            _soundButton.Dock = DockStyle.Fill;
            _soundButton.ImageKey = "volume.png";
            _soundButton.ImageList = imageList1;
            _soundButton.Location = new Point(3, 3);
            _soundButton.Name = "_soundButton";
            _soundButton.Size = new Size(28, 28);
            _soundButton.TabIndex = 6;
            _soundButton.UseVisualStyleBackColor = true;
            _soundButton.Click += _soundButton_Click;
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
            imageList1.Images.SetKeyName(4, "volume.png");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(217, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 34);
            label2.TabIndex = 2;
            label2.Text = "Translate:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _wordText
            // 
            _wordText.Dock = DockStyle.Fill;
            _wordText.Location = new Point(37, 3);
            _wordText.Name = "_wordText";
            _wordText.ReadOnly = true;
            _wordText.Size = new Size(174, 27);
            _wordText.TabIndex = 1;
            // 
            // _translateCombo
            // 
            _translateCombo.Dock = DockStyle.Fill;
            _translateCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            _translateCombo.FormattingEnabled = true;
            _translateCombo.Location = new Point(295, 3);
            _translateCombo.Name = "_translateCombo";
            _translateCombo.Size = new Size(174, 28);
            _translateCombo.TabIndex = 3;
            // 
            // _addButton
            // 
            _addButton.Dock = DockStyle.Fill;
            _addButton.Location = new Point(475, 3);
            _addButton.Menu = contextMenuStrip1;
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(103, 28);
            _addButton.TabIndex = 4;
            _addButton.Text = "Add";
            _addButton.UseVisualStyleBackColor = true;
            _addButton.Click += _addButtonClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(128, 52);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(127, 24);
            toolStripMenuItem2.Text = "Delete";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(127, 24);
            toolStripMenuItem3.Text = "Update";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 46);
            panel1.TabIndex = 1;
            // 
            // AddWordItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddWordItemControl";
            Size = new Size(583, 46);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox _wordText;
        private ComboBox _translateCombo;
        private ImageList imageList1;
        private Panel panel1;
        private Dictionary.SplitButton _addButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Dictionary.SplitButton _soundButton;
    }
}
