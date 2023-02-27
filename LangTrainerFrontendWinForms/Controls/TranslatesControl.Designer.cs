namespace LangTrainerFrontendWinForms.Controls
{
    partial class TranslatesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatesControl));
            groupBox2 = new GroupBox();
            tableLayoutPanel13 = new TableLayoutPanel();
            button9 = new Button();
            imageList1 = new ImageList(components);
            comboBox3 = new ComboBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            groupBox2.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel13);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(512, 263);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Translates";
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 3;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel13.Controls.Add(button9, 2, 0);
            tableLayoutPanel13.Controls.Add(comboBox3, 1, 0);
            tableLayoutPanel13.Controls.Add(textBox2, 0, 0);
            tableLayoutPanel13.Controls.Add(listBox1, 0, 1);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 27);
            tableLayoutPanel13.Margin = new Padding(0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 3;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel13.Size = new Size(506, 233);
            tableLayoutPanel13.TabIndex = 6;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.ImageKey = "plus.png";
            button9.ImageList = imageList1;
            button9.Location = new Point(464, 3);
            button9.Name = "button9";
            button9.Size = new Size(39, 34);
            button9.TabIndex = 5;
            button9.UseVisualStyleBackColor = true;
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
            // comboBox3
            // 
            comboBox3.Dock = DockStyle.Fill;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "english", "france" });
            comboBox3.Location = new Point(284, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(174, 33);
            comboBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 31);
            textBox2.TabIndex = 0;
            // 
            // listBox1
            // 
            tableLayoutPanel13.SetColumnSpan(listBox1, 2);
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "translate 1", "translate 2", "translate 3", "translate 4", "translate 5" });
            listBox1.Location = new Point(3, 43);
            listBox1.Name = "listBox1";
            tableLayoutPanel13.SetRowSpan(listBox1, 2);
            listBox1.Size = new Size(455, 187);
            listBox1.TabIndex = 6;
            // 
            // TranslatesControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(groupBox2);
            Margin = new Padding(0);
            Name = "TranslatesControl";
            Size = new Size(512, 263);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel13;
        private Button button9;
        private ComboBox comboBox3;
        private TextBox textBox2;
        private ListBox listBox1;
        private ImageList imageList1;
    }
}
