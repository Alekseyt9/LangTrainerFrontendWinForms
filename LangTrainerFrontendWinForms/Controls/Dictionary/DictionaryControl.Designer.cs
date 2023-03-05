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
            comboBox1 = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            _addWordButton = new Button();
            imageList1 = new ImageList(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            tableLayoutPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(776, 33);
            comboBox1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Controls.Add(_addWordButton, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.069767F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.93023F));
            tableLayoutPanel1.Size = new Size(823, 430);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // _addWordButton
            // 
            _addWordButton.ImageIndex = 3;
            _addWordButton.ImageList = imageList1;
            _addWordButton.Location = new Point(785, 3);
            _addWordButton.Name = "_addWordButton";
            _addWordButton.Size = new Size(34, 32);
            _addWordButton.TabIndex = 3;
            _addWordButton.UseVisualStyleBackColor = true;
            _addWordButton.Click += AddWordClick;
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
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 462);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(823, 32);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(76, 25);
            toolStripStatusLabel1.Text = "Loading";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.MarqueeAnimationSpeed = 50;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 24);
            toolStripProgressBar1.Step = 1;
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            // 
            // DictionaryControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            Name = "DictionaryControl";
            Size = new Size(823, 494);
            tableLayoutPanel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button _addWordButton;
        private ImageList imageList1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}
