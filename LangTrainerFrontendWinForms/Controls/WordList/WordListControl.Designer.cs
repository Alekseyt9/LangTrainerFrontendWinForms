namespace LangTrainerFrontendWinForms.Controls.WordList
{
    partial class WordListControl
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
            groupBox1 = new GroupBox();
            _itemsTableLayout = new TableLayoutPanel();
            _searchControl = new SearchControl();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(_searchControl, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(571, 435);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(_itemsTableLayout);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(3, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(565, 389);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // _itemsTableLayout
            // 
            _itemsTableLayout.AutoScroll = true;
            _itemsTableLayout.AutoSize = true;
            _itemsTableLayout.ColumnCount = 1;
            _itemsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _itemsTableLayout.Dock = DockStyle.Fill;
            _itemsTableLayout.Location = new Point(3, 23);
            _itemsTableLayout.Name = "_itemsTableLayout";
            _itemsTableLayout.RowCount = 4;
            _itemsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            _itemsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            _itemsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            _itemsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _itemsTableLayout.Size = new Size(559, 363);
            _itemsTableLayout.TabIndex = 0;
            // 
            // _searchControl
            // 
            _searchControl.Dock = DockStyle.Fill;
            _searchControl.Location = new Point(3, 3);
            _searchControl.Name = "_searchControl";
            _searchControl.Size = new Size(565, 34);
            _searchControl.TabIndex = 3;
            // 
            // WordListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(tableLayoutPanel1);
            Name = "WordListControl";
            Size = new Size(571, 435);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private SearchControl _searchControl;
        private GroupBox groupBox1;
        private TableLayoutPanel _itemsTableLayout;
    }
}
