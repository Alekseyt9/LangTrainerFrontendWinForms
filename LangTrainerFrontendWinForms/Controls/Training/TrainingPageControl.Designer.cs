namespace LangTrainerFrontendWinForms.Controls.Training
{
    partial class TrainingPageControl
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
            _tabPanel = new TabPanel();
            SuspendLayout();
            // 
            // tabPanel1
            // 
            _tabPanel.BackColor = SystemColors.ControlLightLight;
            _tabPanel.Dock = DockStyle.Fill;
            _tabPanel.Location = new Point(0, 0);
            _tabPanel.Margin = new Padding(0);
            _tabPanel.Name = "_tabPanel";
            _tabPanel.Size = new Size(527, 417);
            _tabPanel.TabIndex = 0;
            // 
            // TrainingControl2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_tabPanel);
            Name = "TrainingControl2";
            Size = new Size(527, 417);
            ResumeLayout(false);
        }

        #endregion

        private TabPanel _tabPanel;
    }
}
