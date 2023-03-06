namespace LangTrainerFrontendWinForms.Controls.Dictionary.Items
{
    partial class AddWordItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWordItemControl));
            tableLayoutPanel1 = new TableLayoutPanel();
            _addWordButton = new Button();
            imageList1 = new ImageList(components);
            label2 = new Label();
            label1 = new Label();
            _wordText = new TextBox();
            _translateCombo = new ComboBox();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Controls.Add(_addWordButton, 4, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(_wordText, 1, 0);
            tableLayoutPanel1.Controls.Add(_translateCombo, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(448, 44);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // _addWordButton
            // 
            _addWordButton.Dock = DockStyle.Fill;
            _addWordButton.ImageIndex = 3;
            _addWordButton.ImageList = imageList1;
            _addWordButton.Location = new Point(414, 2);
            _addWordButton.Margin = new Padding(2);
            _addWordButton.Name = "_addWordButton";
            _addWordButton.Size = new Size(32, 30);
            _addWordButton.TabIndex = 4;
            _addWordButton.UseVisualStyleBackColor = true;
            _addWordButton.Click += _addWordButtonClick;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(197, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 34);
            label2.TabIndex = 2;
            label2.Text = "Translate:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 34);
            label1.TabIndex = 0;
            label1.Text = "Word:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _wordText
            // 
            _wordText.Dock = DockStyle.Fill;
            _wordText.Location = new Point(57, 3);
            _wordText.Name = "_wordText";
            _wordText.ReadOnly = true;
            _wordText.Size = new Size(134, 27);
            _wordText.TabIndex = 1;
            // 
            // _translateCombo
            // 
            _translateCombo.Dock = DockStyle.Fill;
            _translateCombo.FormattingEnabled = true;
            _translateCombo.Location = new Point(275, 3);
            _translateCombo.Name = "_translateCombo";
            _translateCombo.Size = new Size(134, 28);
            _translateCombo.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 46);
            panel1.TabIndex = 1;
            // 
            // AddWordItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddWordItem";
            Size = new Size(450, 46);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private TextBox _wordText;
        private ComboBox _translateCombo;
        private ImageList imageList1;
        private Button _addWordButton;
        private Panel panel1;
    }
}
