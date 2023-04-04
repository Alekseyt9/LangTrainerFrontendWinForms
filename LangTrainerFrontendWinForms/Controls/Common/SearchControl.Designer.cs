namespace LangTrainerFrontendWinForms.Controls.Common
{
    partial class SearchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            tableLayoutPanel3 = new TableLayoutPanel();
            _clearButton = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            _searchText = new TextBox();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(623, 47);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // _clearButton
            // 
            _clearButton.ImageIndex = 5;
            _clearButton.ImageList = imageList1;
            _clearButton.Location = new Point(590, 2);
            _clearButton.Margin = new Padding(0, 2, 2, 2);
            _clearButton.Name = "_clearButton";
            _clearButton.Size = new Size(29, 29);
            _clearButton.TabIndex = 5;
            _clearButton.UseVisualStyleBackColor = true;
            _clearButton.Click += _clearButton_Click;
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
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // _searchText
            // 
            _searchText.Dock = DockStyle.Fill;
            _searchText.Location = new Point(36, 3);
            _searchText.Margin = new Padding(3, 3, 0, 3);
            _searchText.Name = "_searchText";
            _searchText.Size = new Size(554, 27);
            _searchText.TabIndex = 1;
            _searchText.TextChanged += _searchText_TextChanged;
            // 
            // SearchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel3);
            Name = "SearchControl";
            Size = new Size(623, 47);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Button _clearButton;
        private PictureBox pictureBox1;
        private TextBox _searchText;
        private ImageList imageList1;
    }
}
