namespace LangTrainerFrontendWinForms
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            exStartControl1 = new Controls.Training.ExStart.ExStartControl();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            _tabControl = new TabControl();
            tabPage7 = new TabPage();
            trainerPage = new TabPage();
            dictionaryPage = new TabPage();
            comboBox1 = new ComboBox();
            tabPage9 = new TabPage();
            sentenceEditControl1 = new Controls.SentenceEditControl();
            taskPage = new TabPage();
            tasksControl1 = new Controls.Tasks.TasksControl();
            imageList1 = new ImageList(components);
            menuStrip1 = new MenuStrip();
            dictionaryMenuItem = new ToolStripMenuItem();
            trainingMenuItem = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            tasksMenuItem1 = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            _tabControl.SuspendLayout();
            trainerPage.SuspendLayout();
            dictionaryPage.SuspendLayout();
            tabPage9.SuspendLayout();
            taskPage.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1060, 515);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(exStartControl1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1052, 477);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Exercize1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // exStartControl1
            // 
            exStartControl1.Dock = DockStyle.Fill;
            exStartControl1.Location = new Point(3, 3);
            exStartControl1.Name = "exStartControl1";
            exStartControl1.Size = new Size(1046, 471);
            exStartControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1052, 477);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Exercize2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1052, 477);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Exercize3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1052, 477);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Exercize4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1052, 477);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Resut";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1060, 515);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // _tabControl
            // 
            _tabControl.Controls.Add(tabPage7);
            _tabControl.Controls.Add(trainerPage);
            _tabControl.Controls.Add(dictionaryPage);
            _tabControl.Controls.Add(tabPage9);
            _tabControl.Controls.Add(taskPage);
            _tabControl.Dock = DockStyle.Fill;
            _tabControl.Location = new Point(0, 33);
            _tabControl.Name = "_tabControl";
            _tabControl.SelectedIndex = 0;
            _tabControl.Size = new Size(1074, 559);
            _tabControl.TabIndex = 3;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 34);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1066, 521);
            tabPage7.TabIndex = 1;
            tabPage7.Text = "Login";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // trainerPage
            // 
            trainerPage.Controls.Add(tableLayoutPanel3);
            trainerPage.Location = new Point(4, 34);
            trainerPage.Name = "trainerPage";
            trainerPage.Padding = new Padding(3);
            trainerPage.Size = new Size(1066, 521);
            trainerPage.TabIndex = 0;
            trainerPage.Text = "Trainer";
            trainerPage.UseVisualStyleBackColor = true;
            // 
            // dictionaryPage
            // 
            dictionaryPage.Controls.Add(comboBox1);
            dictionaryPage.Location = new Point(4, 34);
            dictionaryPage.Name = "dictionaryPage";
            dictionaryPage.Size = new Size(1066, 521);
            dictionaryPage.TabIndex = 2;
            dictionaryPage.Text = "Dictionary";
            dictionaryPage.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(1066, 33);
            comboBox1.TabIndex = 1;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(sentenceEditControl1);
            tabPage9.Location = new Point(4, 34);
            tabPage9.Name = "tabPage9";
            tabPage9.Size = new Size(1066, 521);
            tabPage9.TabIndex = 3;
            tabPage9.Text = "EditSentence";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // sentenceEditControl1
            // 
            sentenceEditControl1.Dock = DockStyle.Fill;
            sentenceEditControl1.Location = new Point(0, 0);
            sentenceEditControl1.Margin = new Padding(0);
            sentenceEditControl1.Name = "sentenceEditControl1";
            sentenceEditControl1.Size = new Size(1066, 521);
            sentenceEditControl1.TabIndex = 0;
            // 
            // taskPage
            // 
            taskPage.Controls.Add(tasksControl1);
            taskPage.Location = new Point(4, 34);
            taskPage.Name = "taskPage";
            taskPage.Size = new Size(1066, 521);
            taskPage.TabIndex = 4;
            taskPage.Text = "Tasks";
            taskPage.UseVisualStyleBackColor = true;
            // 
            // tasksControl1
            // 
            tasksControl1.Dock = DockStyle.Fill;
            tasksControl1.Location = new Point(0, 0);
            tasksControl1.Name = "tasksControl1";
            tasksControl1.Size = new Size(1066, 521);
            tasksControl1.TabIndex = 0;
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dictionaryMenuItem, trainingMenuItem, tasksToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1074, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // dictionaryMenuItem
            // 
            dictionaryMenuItem.Name = "dictionaryMenuItem";
            dictionaryMenuItem.Size = new Size(108, 29);
            dictionaryMenuItem.Text = "Dictionary";
            dictionaryMenuItem.Click += dictionaryMenuItemClick;
            // 
            // trainingMenuItem
            // 
            trainingMenuItem.Name = "trainingMenuItem";
            trainingMenuItem.Size = new Size(89, 29);
            trainingMenuItem.Text = "Training";
            trainingMenuItem.Click += trainingMenuItemClick;
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tasksMenuItem1 });
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new Size(81, 29);
            tasksToolStripMenuItem.Text = "Admin";
            // 
            // tasksMenuItem1
            // 
            tasksMenuItem1.Name = "tasksMenuItem1";
            tasksMenuItem1.Size = new Size(155, 34);
            tasksMenuItem1.Text = "Tasks";
            tasksMenuItem1.Click += tasksMenuItem1Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 592);
            Controls.Add(_tabControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "LangTrainer";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            _tabControl.ResumeLayout(false);
            trainerPage.ResumeLayout(false);
            dictionaryPage.ResumeLayout(false);
            tabPage9.ResumeLayout(false);
            taskPage.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel3;
        private TabPage tabPage5;
        private TabControl _tabControl;
        private TabPage tabPage7;
        private TabPage trainerPage;
        private TabPage dictionaryPage;
        private ComboBox comboBox1;
        private TabPage tabPage9;
        private ImageList imageList1;
        private Controls.SentenceEditControl sentenceEditControl1;
        private Controls.Training.ExStart.ExStartControl exStartControl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem dictionaryMenuItem;
        private ToolStripMenuItem trainingMenuItem;
        private TabPage taskPage;
        private Controls.Tasks.TasksControl tasksControl1;
        private ToolStripMenuItem tasksMenuItem1;
    }
}