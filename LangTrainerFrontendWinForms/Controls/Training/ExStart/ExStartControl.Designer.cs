namespace LangTrainerFrontendWinForms.Controls.Training.ExStart
{
    partial class ExStartControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            _labelRepeat = new Labels.LabelRepeat();
            _labelNew = new Labels.LabelNew();
            _labelMatur = new Labels.LabelMatur();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 450F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(_labelRepeat, 1, 1);
            tableLayoutPanel1.Controls.Add(_labelNew, 1, 2);
            tableLayoutPanel1.Controls.Add(_labelMatur, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(663, 438);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // _labelRepeat
            // 
            _labelRepeat.Cursor = Cursors.Hand;
            _labelRepeat.Location = new Point(118, 63);
            _labelRepeat.Margin = new Padding(12);
            _labelRepeat.Name = "_labelRepeat";
            _labelRepeat.Size = new Size(426, 88);
            _labelRepeat.TabIndex = 0;
            // 
            // _labelNew
            // 
            _labelNew.Cursor = Cursors.Hand;
            _labelNew.Location = new Point(118, 175);
            _labelNew.Margin = new Padding(12);
            _labelNew.Name = "_labelNew";
            _labelNew.Size = new Size(426, 88);
            _labelNew.TabIndex = 1;
            // 
            // _labelMatur
            // 
            _labelMatur.Cursor = Cursors.Hand;
            _labelMatur.Location = new Point(118, 287);
            _labelMatur.Margin = new Padding(12);
            _labelMatur.Name = "_labelMatur";
            _labelMatur.Size = new Size(426, 88);
            _labelMatur.TabIndex = 2;
            // 
            // ExStartControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "ExStartControl";
            Size = new Size(663, 438);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion



        private TableLayoutPanel tableLayoutPanel1;
        private Labels.LabelRepeat _labelRepeat;
        private Labels.LabelNew _labelNew;
        private Labels.LabelMatur _labelMatur;
    }
}
