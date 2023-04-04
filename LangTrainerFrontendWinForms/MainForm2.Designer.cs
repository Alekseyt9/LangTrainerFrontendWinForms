namespace LangTrainerFrontendWinForms
{
    partial class MainForm2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            _tabPanel = new Controls.TabPanel();
            _mainMenuStrip = new MenuStrip();
            dictionaryMenuItem = new ToolStripMenuItem();
            wordListMenuItem = new ToolStripMenuItem();
            trainingMenuItem = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            tasksMenuItem1 = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            getmanToolStripMenuItem = new ToolStripMenuItem();
            translateLanguageToolStripMenuItem = new ToolStripMenuItem();
            russianToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem1 = new ToolStripMenuItem();
            _toolTip = new ToolTip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            _mainMenuStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // _tabPanel
            // 
            _tabPanel.BackColor = SystemColors.ControlLightLight;
            _tabPanel.Dock = DockStyle.Fill;
            _tabPanel.Location = new Point(0, 0);
            _tabPanel.Margin = new Padding(0);
            _tabPanel.Name = "_tabPanel";
            _tabPanel.Size = new Size(905, 523);
            _tabPanel.TabIndex = 0;
            // 
            // _mainMenuStrip
            // 
            _mainMenuStrip.BackColor = SystemColors.ControlLightLight;
            _mainMenuStrip.ImageScalingSize = new Size(24, 24);
            _mainMenuStrip.Items.AddRange(new ToolStripItem[] { dictionaryMenuItem, wordListMenuItem, trainingMenuItem, tasksToolStripMenuItem, optionsToolStripMenuItem });
            _mainMenuStrip.Location = new Point(0, 0);
            _mainMenuStrip.Name = "_mainMenuStrip";
            _mainMenuStrip.Padding = new Padding(5, 2, 0, 2);
            _mainMenuStrip.Size = new Size(905, 28);
            _mainMenuStrip.TabIndex = 5;
            _mainMenuStrip.Text = "menuStrip1";
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
            wordListMenuItem.Size = new Size(76, 24);
            wordListMenuItem.Text = "Training";
            wordListMenuItem.Click += wordListMenuItem_Click;
            // 
            // trainingMenuItem
            // 
            trainingMenuItem.Name = "trainingMenuItem";
            trainingMenuItem.Size = new Size(82, 24);
            trainingMenuItem.Text = "Exercises";
            trainingMenuItem.Visible = false;
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
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { languageToolStripMenuItem, translateLanguageToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, getmanToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(224, 26);
            languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.CheckOnClick = true;
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(224, 26);
            englishToolStripMenuItem.Text = "English";
            // 
            // getmanToolStripMenuItem
            // 
            getmanToolStripMenuItem.CheckOnClick = true;
            getmanToolStripMenuItem.Name = "getmanToolStripMenuItem";
            getmanToolStripMenuItem.Size = new Size(224, 26);
            getmanToolStripMenuItem.Text = "Getman";
            // 
            // translateLanguageToolStripMenuItem
            // 
            translateLanguageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { russianToolStripMenuItem, englishToolStripMenuItem1 });
            translateLanguageToolStripMenuItem.Name = "translateLanguageToolStripMenuItem";
            translateLanguageToolStripMenuItem.Size = new Size(224, 26);
            translateLanguageToolStripMenuItem.Text = "TranslateLanguage";
            // 
            // russianToolStripMenuItem
            // 
            russianToolStripMenuItem.CheckOnClick = true;
            russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            russianToolStripMenuItem.Size = new Size(224, 26);
            russianToolStripMenuItem.Text = "Russian";
            // 
            // englishToolStripMenuItem1
            // 
            englishToolStripMenuItem1.CheckOnClick = true;
            englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            englishToolStripMenuItem1.Size = new Size(224, 26);
            englishToolStripMenuItem1.Text = "English";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(_tabPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(905, 523);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // MainForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(905, 551);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(_mainMenuStrip);
            Name = "MainForm2";
            Text = "Language trainer";
            Load += MainForm2_Load;
            _mainMenuStrip.ResumeLayout(false);
            _mainMenuStrip.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.TabPanel _tabPanel;
        private MenuStrip _mainMenuStrip;
        private ToolStripMenuItem dictionaryMenuItem;
        private ToolStripMenuItem wordListMenuItem;
        private ToolStripMenuItem trainingMenuItem;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem tasksMenuItem1;
        private ToolTip _toolTip;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem getmanToolStripMenuItem;
        private ToolStripMenuItem translateLanguageToolStripMenuItem;
        private ToolStripMenuItem russianToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem1;
    }
}