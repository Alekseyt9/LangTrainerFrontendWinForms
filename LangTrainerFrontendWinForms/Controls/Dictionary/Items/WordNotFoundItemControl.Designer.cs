namespace LangTrainerFrontendWinForms.Controls
{
    partial class WordNotFoundItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordNotFoundItemControl));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            _label = new Label();
            _loadButton = new Button();
            label1 = new Label();
            _languageCombo = new ComboBox();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 41);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(_label, 0, 0);
            tableLayoutPanel1.Controls.Add(_loadButton, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(_languageCombo, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(788, 39);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // _label
            // 
            _label.AutoSize = true;
            _label.Dock = DockStyle.Fill;
            _label.Location = new Point(3, 0);
            _label.Name = "_label";
            _label.Size = new Size(497, 34);
            _label.TabIndex = 0;
            _label.Text = "Word '{str}' not found in database, try load the word from sites";
            _label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _loadButton
            // 
            _loadButton.Location = new Point(734, 3);
            _loadButton.Name = "_loadButton";
            _loadButton.Size = new Size(51, 28);
            _loadButton.TabIndex = 1;
            _loadButton.Text = "Load";
            _loadButton.UseVisualStyleBackColor = true;
            _loadButton.Click += loadButtonClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(506, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 34);
            label1.TabIndex = 2;
            label1.Text = "Language:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _languageCombo
            // 
            _languageCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            _languageCombo.FormattingEnabled = true;
            _languageCombo.Location = new Point(593, 3);
            _languageCombo.Name = "_languageCombo";
            _languageCombo.Size = new Size(135, 28);
            _languageCombo.TabIndex = 3;
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
            // WordNotFoundItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "WordNotFoundItemControl";
            Size = new Size(790, 41);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label _label;
        private Button _loadButton;
        private ImageList imageList1;
        private Label label1;
        private ComboBox _languageCombo;
    }
}
