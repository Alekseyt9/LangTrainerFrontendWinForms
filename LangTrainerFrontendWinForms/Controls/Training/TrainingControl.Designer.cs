namespace LangTrainerFrontendWinForms.Controls.Training
{
    partial class TrainingControl
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
            _tabControl = new TabControl();
            tabPage1 = new TabPage();
            exStartControl1 = new ExStart.ExStartControl();
            tabPage6 = new TabPage();
            ex1Control1 = new Ex1.Ex1Control();
            tabPage2 = new TabPage();
            ex2Control1 = new Ex2.Ex2Control();
            tabPage3 = new TabPage();
            ex3Control1 = new Ex3.Ex3Control();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            _tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // _tabControl
            // 
            _tabControl.Controls.Add(tabPage1);
            _tabControl.Controls.Add(tabPage6);
            _tabControl.Controls.Add(tabPage2);
            _tabControl.Controls.Add(tabPage3);
            _tabControl.Controls.Add(tabPage4);
            _tabControl.Controls.Add(tabPage5);
            _tabControl.Dock = DockStyle.Fill;
            _tabControl.Location = new Point(0, 0);
            _tabControl.Margin = new Padding(0);
            _tabControl.Multiline = true;
            _tabControl.Name = "_tabControl";
            _tabControl.Padding = new Point(0, 0);
            _tabControl.SelectedIndex = 0;
            _tabControl.Size = new Size(782, 583);
            _tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(exStartControl1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(774, 550);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Start";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // exStartControl1
            // 
            exStartControl1.Dock = DockStyle.Fill;
            exStartControl1.Location = new Point(2, 2);
            exStartControl1.Margin = new Padding(0);
            exStartControl1.Name = "exStartControl1";
            exStartControl1.Size = new Size(770, 546);
            exStartControl1.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(ex1Control1);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(2);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(774, 550);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Exercize1";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // ex1Control1
            // 
            ex1Control1.Dock = DockStyle.Fill;
            ex1Control1.Location = new Point(0, 0);
            ex1Control1.Margin = new Padding(2, 2, 2, 2);
            ex1Control1.Name = "ex1Control1";
            ex1Control1.Size = new Size(774, 550);
            ex1Control1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ex2Control1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(774, 550);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Exercize2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ex2Control1
            // 
            ex2Control1.Dock = DockStyle.Fill;
            ex2Control1.Location = new Point(2, 2);
            ex2Control1.Margin = new Padding(2, 2, 2, 2);
            ex2Control1.Name = "ex2Control1";
            ex2Control1.Size = new Size(770, 546);
            ex2Control1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(ex3Control1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(774, 550);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Exercize3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // ex3Control1
            // 
            ex3Control1.Dock = DockStyle.Fill;
            ex3Control1.Location = new Point(0, 0);
            ex3Control1.Margin = new Padding(2, 2, 2, 2);
            ex3Control1.Name = "ex3Control1";
            ex3Control1.Size = new Size(774, 550);
            ex3Control1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(774, 550);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Exercize4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Margin = new Padding(2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(774, 550);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Resut";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // TrainingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(_tabControl);
            Name = "TrainingControl";
            Size = new Size(782, 583);
            _tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl _tabControl;
        private TabPage tabPage1;
        private ExStart.ExStartControl exStartControl1;
        private TabPage tabPage6;
        private Ex1.Ex1Control ex1Control1;
        private TabPage tabPage2;
        private Ex2.Ex2Control ex2Control1;
        private TabPage tabPage3;
        private Ex3.Ex3Control ex3Control1;
        private TabPage tabPage4;
        private TabPage tabPage5;
    }
}
