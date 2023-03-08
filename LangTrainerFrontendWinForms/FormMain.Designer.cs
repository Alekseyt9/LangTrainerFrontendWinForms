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
            tableLayoutPanel3 = new TableLayoutPanel();
            trainingControl1 = new Controls.Training.TrainingControl();
            _tabControl = new TabControl();
            tabPage7 = new TabPage();
            wordListControl1 = new Controls.WordList.WordListControl();
            trainerPage = new TabPage();
            dictionaryPage = new TabPage();
            dictionaryControl1 = new Controls.DictionaryControl();
            tabPage9 = new TabPage();
            sentenceEditControl1 = new Controls.SentenceEditControl();
            taskPage = new TabPage();
            tasksControl1 = new Controls.Tasks.TasksControl();
            wordListPage = new TabPage();
            imageList1 = new ImageList(components);
            menuStrip1 = new MenuStrip();
            dictionaryMenuItem = new ToolStripMenuItem();
            wordListMenuItem = new ToolStripMenuItem();
            trainingMenuItem = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            tasksMenuItem1 = new ToolStripMenuItem();
            notifyIcon1 = new NotifyIcon(components);
            tableLayoutPanel3.SuspendLayout();
            _tabControl.SuspendLayout();
            tabPage7.SuspendLayout();
            trainerPage.SuspendLayout();
            dictionaryPage.SuspendLayout();
            tabPage9.SuspendLayout();
            taskPage.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(trainingControl1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(2, 2);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel3.Size = new Size(188, 63);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // trainingControl1
            // 
            trainingControl1.Dock = DockStyle.Fill;
            trainingControl1.Location = new Point(3, 3);
            trainingControl1.Name = "trainingControl1";
            trainingControl1.Size = new Size(182, 57);
            trainingControl1.TabIndex = 0;
            // 
            // _tabControl
            // 
            _tabControl.Controls.Add(tabPage7);
            _tabControl.Controls.Add(trainerPage);
            _tabControl.Controls.Add(dictionaryPage);
            _tabControl.Controls.Add(tabPage9);
            _tabControl.Controls.Add(taskPage);
            _tabControl.Controls.Add(wordListPage);
            _tabControl.Dock = DockStyle.Fill;
            _tabControl.Location = new Point(0, 28);
            _tabControl.Margin = new Padding(2);
            _tabControl.Name = "_tabControl";
            _tabControl.SelectedIndex = 0;
            _tabControl.Size = new Size(740, 455);
            _tabControl.TabIndex = 3;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(wordListControl1);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Margin = new Padding(2);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(2);
            tabPage7.Size = new Size(732, 422);
            tabPage7.TabIndex = 1;
            tabPage7.Text = "Login";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // wordListControl1
            // 
            wordListControl1.Dock = DockStyle.Fill;
            wordListControl1.Location = new Point(2, 2);
            wordListControl1.Name = "wordListControl1";
            wordListControl1.Size = new Size(728, 418);
            wordListControl1.TabIndex = 0;
            // 
            // trainerPage
            // 
            trainerPage.Controls.Add(tableLayoutPanel3);
            trainerPage.Location = new Point(4, 29);
            trainerPage.Margin = new Padding(2);
            trainerPage.Name = "trainerPage";
            trainerPage.Padding = new Padding(2);
            trainerPage.Size = new Size(192, 67);
            trainerPage.TabIndex = 0;
            trainerPage.Text = "Trainer";
            trainerPage.UseVisualStyleBackColor = true;
            // 
            // dictionaryPage
            // 
            dictionaryPage.Controls.Add(dictionaryControl1);
            dictionaryPage.Location = new Point(4, 29);
            dictionaryPage.Margin = new Padding(2);
            dictionaryPage.Name = "dictionaryPage";
            dictionaryPage.Size = new Size(192, 67);
            dictionaryPage.TabIndex = 2;
            dictionaryPage.Text = "Dictionary";
            dictionaryPage.UseVisualStyleBackColor = true;
            // 
            // dictionaryControl1
            // 
            dictionaryControl1.Dock = DockStyle.Fill;
            dictionaryControl1.Location = new Point(0, 0);
            dictionaryControl1.Margin = new Padding(2);
            dictionaryControl1.Name = "dictionaryControl1";
            dictionaryControl1.Size = new Size(192, 67);
            dictionaryControl1.TabIndex = 0;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(sentenceEditControl1);
            tabPage9.Location = new Point(4, 29);
            tabPage9.Margin = new Padding(2);
            tabPage9.Name = "tabPage9";
            tabPage9.Size = new Size(192, 67);
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
            sentenceEditControl1.Size = new Size(192, 67);
            sentenceEditControl1.TabIndex = 0;
            // 
            // taskPage
            // 
            taskPage.Controls.Add(tasksControl1);
            taskPage.Location = new Point(4, 29);
            taskPage.Margin = new Padding(2);
            taskPage.Name = "taskPage";
            taskPage.Size = new Size(192, 67);
            taskPage.TabIndex = 4;
            taskPage.Text = "Tasks";
            taskPage.UseVisualStyleBackColor = true;
            // 
            // tasksControl1
            // 
            tasksControl1.Dock = DockStyle.Fill;
            tasksControl1.Location = new Point(0, 0);
            tasksControl1.Margin = new Padding(2, 2, 2, 2);
            tasksControl1.Name = "tasksControl1";
            tasksControl1.Size = new Size(192, 67);
            tasksControl1.TabIndex = 0;
            // 
            // wordListPage
            // 
            wordListPage.Location = new Point(4, 29);
            wordListPage.Name = "wordListPage";
            wordListPage.Size = new Size(192, 67);
            wordListPage.TabIndex = 5;
            wordListPage.Text = "Word list";
            wordListPage.UseVisualStyleBackColor = true;
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dictionaryMenuItem, wordListMenuItem, trainingMenuItem, tasksToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(740, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // dictionaryMenuItem
            // 
            dictionaryMenuItem.Name = "dictionaryMenuItem";
            dictionaryMenuItem.Size = new Size(91, 24);
            dictionaryMenuItem.Text = "Dictionary";
            dictionaryMenuItem.Click += DictionaryMenuItemClick;
            // 
            // wordListMenuItem
            // 
            wordListMenuItem.Name = "wordListMenuItem";
            wordListMenuItem.Size = new Size(82, 24);
            wordListMenuItem.Text = "Word list";
            wordListMenuItem.Click += wordListMenuItem_Click;
            // 
            // trainingMenuItem
            // 
            trainingMenuItem.Name = "trainingMenuItem";
            trainingMenuItem.Size = new Size(76, 24);
            trainingMenuItem.Text = "Training";
            trainingMenuItem.Click += TrainingMenuItemClick;
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tasksMenuItem1 });
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new Size(67, 24);
            tasksToolStripMenuItem.Text = "Admin";
            tasksToolStripMenuItem.Visible = false;
            // 
            // tasksMenuItem1
            // 
            tasksMenuItem1.Name = "tasksMenuItem1";
            tasksMenuItem1.Size = new Size(125, 26);
            tasksMenuItem1.Text = "Tasks";
            tasksMenuItem1.Click += TasksMenuItem1Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 483);
            Controls.Add(_tabControl);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            MinimumSize = new Size(559, 487);
            Name = "FormMain";
            Text = "LangTrainer";
            tableLayoutPanel3.ResumeLayout(false);
            _tabControl.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel3;
        private TabControl _tabControl;
        private TabPage tabPage7;
        private TabPage trainerPage;
        private TabPage dictionaryPage;
        private TabPage tabPage9;
        private ImageList imageList1;
        private Controls.SentenceEditControl sentenceEditControl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem dictionaryMenuItem;
        private ToolStripMenuItem trainingMenuItem;
        private TabPage taskPage;
        private Controls.Tasks.TasksControl tasksControl1;
        private ToolStripMenuItem tasksMenuItem1;
        private Controls.DictionaryControl dictionaryControl1;
        private Controls.Training.TrainingControl trainingControl1;
        private TabPage wordListPage;
        private ToolStripMenuItem wordListMenuItem;
        private Controls.WordList.WordListControl wordListControl1;
        private NotifyIcon notifyIcon1;
    }
}