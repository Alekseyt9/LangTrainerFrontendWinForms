namespace LangTrainerFrontendWinForms.Controls
{
    partial class SamplesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SamplesControl));
            groupBox1 = new GroupBox();
            tableLayoutPanel14 = new TableLayoutPanel();
            button12 = new Button();
            imageList1 = new ImageList(components);
            textBox3 = new TextBox();
            _listBox = new ListBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel14);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(837, 305);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Samples";
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 3;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel14.Controls.Add(button12, 2, 0);
            tableLayoutPanel14.Controls.Add(textBox3, 0, 0);
            tableLayoutPanel14.Controls.Add(_listBox, 0, 1);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(3, 27);
            tableLayoutPanel14.Margin = new Padding(0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 3;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel14.Size = new Size(831, 275);
            tableLayoutPanel14.TabIndex = 7;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.ImageKey = "plus.png";
            button12.ImageList = imageList1;
            button12.Location = new Point(789, 3);
            button12.Name = "button12";
            button12.Size = new Size(39, 34);
            button12.TabIndex = 5;
            button12.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "reload.png");
            imageList1.Images.SetKeyName(1, "boss.png");
            imageList1.Images.SetKeyName(2, "plus.png");
            // 
            // textBox3
            // 
            tableLayoutPanel14.SetColumnSpan(textBox3, 2);
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(3, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(780, 31);
            textBox3.TabIndex = 0;
            // 
            // _listBox
            // 
            tableLayoutPanel14.SetColumnSpan(_listBox, 2);
            _listBox.Dock = DockStyle.Fill;
            _listBox.FormattingEnabled = true;
            _listBox.ItemHeight = 25;
            _listBox.Items.AddRange(new object[] { "sample 1", "sample 2", "sample 3", "sample 4" });
            _listBox.Location = new Point(3, 43);
            _listBox.Name = "_listBox";
            tableLayoutPanel14.SetRowSpan(_listBox, 2);
            _listBox.Size = new Size(780, 229);
            _listBox.TabIndex = 6;
            // 
            // SamplesControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(0);
            Name = "SamplesControl";
            Size = new Size(837, 305);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel14;
        private Button button12;
        private TextBox textBox3;
        private ListBox _listBox;
        private ImageList imageList1;
    }
}
