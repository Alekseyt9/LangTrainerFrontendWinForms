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
            labelRepeat1 = new Labels.LabelRepeat();
            labelNew1 = new Labels.LabelNew();
            labelMatur1 = new Labels.LabelMatur();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 562F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelRepeat1, 1, 1);
            tableLayoutPanel1.Controls.Add(labelNew1, 1, 2);
            tableLayoutPanel1.Controls.Add(labelMatur1, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(829, 547);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelRepeat1
            // 
            labelRepeat1.Location = new Point(148, 78);
            labelRepeat1.Margin = new Padding(15);
            labelRepeat1.Name = "labelRepeat1";
            labelRepeat1.Size = new Size(532, 110);
            labelRepeat1.TabIndex = 0;

            // 
            // labelNew1
            // 
            labelNew1.Location = new Point(148, 218);
            labelNew1.Margin = new Padding(15);
            labelNew1.Name = "labelNew1";
            labelNew1.Size = new Size(532, 110);
            labelNew1.TabIndex = 1;

            // 
            // labelMatur1
            // 
            labelMatur1.Location = new Point(148, 358);
            labelMatur1.Margin = new Padding(15);
            labelMatur1.Name = "labelMatur1";
            labelMatur1.Size = new Size(532, 110);
            labelMatur1.TabIndex = 2;

            // 
            // ExStartControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ExStartControl";
            Size = new Size(829, 547);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion



        private TableLayoutPanel tableLayoutPanel1;
        private Labels.LabelRepeat labelRepeat1;
        private Labels.LabelNew labelNew1;
        private Labels.LabelMatur labelMatur1;
    }
}
