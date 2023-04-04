using LangTrainerFrontendWinForms.Controls.Out.Accordion;

namespace LangTrainerFrontendWinForms.Controls.WordList
{
    partial class WordListPageControl
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
            trainingStartShort1 = new Training.TrainingStartShort();
            groupBox1 = new GroupBox();
            _wordListControl = new WordListControl();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(trainingStartShort1, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 249F));
            tableLayoutPanel1.Size = new Size(685, 597);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // trainingStartShort1
            // 
            trainingStartShort1.Dock = DockStyle.Fill;
            trainingStartShort1.Location = new Point(3, 23);
            trainingStartShort1.Name = "trainingStartShort1";
            trainingStartShort1.Size = new Size(679, 44);
            trainingStartShort1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(_wordListControl);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(679, 501);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "My dictionary";
            // 
            // wordList1
            // 
            _wordListControl.BackColor = SystemColors.ControlLightLight;
            _wordListControl.Dock = DockStyle.Fill;
            _wordListControl.Location = new Point(3, 23);
            _wordListControl.Name = "_wordListControl";
            _wordListControl.Size = new Size(673, 475);
            _wordListControl.TabIndex = 0;
            // 
            // WordListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(tableLayoutPanel1);
            Name = "WordListControl";
            Size = new Size(685, 597);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Training.TrainingStartShort trainingStartShort1;
        private GroupBox groupBox1;
        private WordListControl _wordListControl;
    }
}
