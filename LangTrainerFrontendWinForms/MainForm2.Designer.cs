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
            _tabPanel = new Controls.Common.TabPanel();
            _mainMenuStrip = new MenuStrip();
            dictionaryMenuItem = new ToolStripMenuItem();
            wordListMenuItem = new ToolStripMenuItem();
            trainingMenuItem = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            tasksMenuItem1 = new ToolStripMenuItem();
            _toolTip = new ToolTip(components);
            _mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // _tabPanel
            // 
            _tabPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _tabPanel.BackColor = SystemColors.ControlLightLight;
            _tabPanel.Location = new Point(0, 28);
            _tabPanel.Margin = new Padding(0);
            _tabPanel.Name = "_tabPanel";
            _tabPanel.Size = new Size(905, 523);
            _tabPanel.TabIndex = 0;
            // 
            // _mainMenuStrip
            // 
            _mainMenuStrip.BackColor = SystemColors.ControlLightLight;
            _mainMenuStrip.ImageScalingSize = new Size(24, 24);
            _mainMenuStrip.Items.AddRange(new ToolStripItem[] { dictionaryMenuItem, wordListMenuItem, trainingMenuItem, tasksToolStripMenuItem });
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
            // MainForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(905, 551);
            Controls.Add(_mainMenuStrip);
            Controls.Add(_tabPanel);
            Name = "MainForm2";
            Text = "Language trainer";
            Load += MainForm2_Load;
            _mainMenuStrip.ResumeLayout(false);
            _mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.Common.TabPanel _tabPanel;
        private MenuStrip _mainMenuStrip;
        private ToolStripMenuItem dictionaryMenuItem;
        private ToolStripMenuItem wordListMenuItem;
        private ToolStripMenuItem trainingMenuItem;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem tasksMenuItem1;
        private ToolTip _toolTip;
    }
}