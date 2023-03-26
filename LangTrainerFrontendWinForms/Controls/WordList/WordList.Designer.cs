namespace LangTrainerFrontendWinForms.Controls.WordList
{
    partial class WordList
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
            searchControl1 = new Common.SearchControl();
            _langFilter = new Common.LangFilter();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            wordListItem1 = new WordListItem();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(searchControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(_langFilter, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(571, 435);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // searchControl1
            // 
            searchControl1.Dock = DockStyle.Fill;
            searchControl1.Location = new Point(3, 3);
            searchControl1.Name = "searchControl1";
            searchControl1.Size = new Size(565, 34);
            searchControl1.TabIndex = 3;
            // 
            // _langFilter
            // 
            _langFilter.Location = new Point(3, 43);
            _langFilter.Name = "_langFilter";
            _langFilter.Size = new Size(565, 32);
            _langFilter.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(565, 349);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Word list";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(wordListItem1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(559, 323);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // wordListItem1
            // 
            wordListItem1.BorderStyle = BorderStyle.FixedSingle;
            wordListItem1.Dock = DockStyle.Fill;
            wordListItem1.Location = new Point(3, 3);
            wordListItem1.Name = "wordListItem1";
            wordListItem1.Size = new Size(553, 44);
            wordListItem1.TabIndex = 0;
            // 
            // WordList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "WordList";
            Size = new Size(571, 435);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Common.SearchControl searchControl1;
        private Common.LangFilter _langFilter;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private WordListItem wordListItem1;
    }
}
