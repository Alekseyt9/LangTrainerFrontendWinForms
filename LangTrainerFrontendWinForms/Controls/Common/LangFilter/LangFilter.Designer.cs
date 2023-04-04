namespace LangTrainerFrontendWinForms.Controls
{
    partial class LangFilter
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            _langFilterCombo = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            clearToolStripMenuItem = new ToolStripMenuItem();
            _trLangFilterCombo = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 152F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(_langFilterCombo, 1, 0);
            tableLayoutPanel2.Controls.Add(_trLangFilterCombo, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(742, 38);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 7);
            label1.Margin = new Padding(3, 7, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Language:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(345, 7);
            label2.Margin = new Padding(3, 7, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 1;
            label2.Text = "Translate language:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _langFilterCombo
            // 
            _langFilterCombo.ContextMenuStrip = contextMenuStrip1;
            _langFilterCombo.Dock = DockStyle.Fill;
            _langFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            _langFilterCombo.FormattingEnabled = true;
            _langFilterCombo.Location = new Point(97, 3);
            _langFilterCombo.Name = "_langFilterCombo";
            _langFilterCombo.Size = new Size(242, 28);
            _langFilterCombo.TabIndex = 2;
            _langFilterCombo.SelectedIndexChanged += _langFilterCombo_SelectedIndexChanged;
            _langFilterCombo.Enter += _langFilterCombo_Enter;
            _langFilterCombo.Validating += _langFilterCombo_Validating;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { clearToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 28);
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(112, 24);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // _trLangFilterCombo
            // 
            _trLangFilterCombo.Dock = DockStyle.Fill;
            _trLangFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            _trLangFilterCombo.FormattingEnabled = true;
            _trLangFilterCombo.Location = new Point(497, 3);
            _trLangFilterCombo.Name = "_trLangFilterCombo";
            _trLangFilterCombo.Size = new Size(242, 28);
            _trLangFilterCombo.TabIndex = 3;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // LangFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "LangFilter";
            Size = new Size(742, 38);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private ComboBox _langFilterCombo;
        private ComboBox _trLangFilterCombo;
        private ErrorProvider errorProvider1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem clearToolStripMenuItem;
    }
}
