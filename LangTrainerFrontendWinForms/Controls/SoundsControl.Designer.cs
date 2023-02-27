namespace LangTrainerFrontendWinForms.Controls
{
    partial class SoundsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundsControl));
            groupBox1 = new GroupBox();
            tableLayoutPanel12 = new TableLayoutPanel();
            button8 = new Button();
            imageList1 = new ImageList(components);
            button7 = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel12);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 209);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sounds";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 3;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(button8, 1, 0);
            tableLayoutPanel12.Controls.Add(button7, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 27);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(436, 179);
            tableLayoutPanel12.TabIndex = 4;
            // 
            // button8
            // 
            button8.ImageKey = "plus.png";
            button8.ImageList = imageList1;
            button8.Location = new Point(43, 3);
            button8.Name = "button8";
            button8.Size = new Size(34, 34);
            button8.TabIndex = 1;
            button8.UseVisualStyleBackColor = true;
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
            // button7
            // 
            button7.ImageKey = "boss.png";
            button7.ImageList = imageList1;
            button7.Location = new Point(3, 3);
            button7.Name = "button7";
            button7.Size = new Size(34, 34);
            button7.TabIndex = 0;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // SoundsControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(0);
            Name = "SoundsControl";
            Size = new Size(442, 209);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel12;
        private Button button8;
        private Button button7;
        private ImageList imageList1;
    }
}
