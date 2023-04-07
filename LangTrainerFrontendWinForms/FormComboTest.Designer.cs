
using LangTrainerFrontendWinForms.Controls;

namespace LangTrainerFrontendWinForms
{
    partial class FormComboTest
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
            comboBox1 = new ComboboxMultiline();
            customComboBox1 = new CustomComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 40;
            comboBox1.Location = new Point(33, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(342, 46);
            comboBox1.TabIndex = 0;
            // 
            // customComboBox1
            // 
            customComboBox1.BackColor = SystemColors.Control;
            customComboBox1.Location = new Point(33, 133);
            customComboBox1.Name = "customComboBox1";
            customComboBox1.Size = new Size(350, 32);
            customComboBox1.TabIndex = 1;
            // 
            // FormComboTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customComboBox1);
            Controls.Add(comboBox1);
            Name = "FormComboTest";
            Text = "FormComboTest";
            ResumeLayout(false);
        }

        #endregion

        private ComboboxMultiline comboBox1;
        private CustomComboBox customComboBox1;
    }
}