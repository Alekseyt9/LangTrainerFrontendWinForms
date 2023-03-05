namespace LangTrainerFrontendWinForms.Controls.Tasks
{
    partial class TasksControl
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addTaskToolStripMenuItem = new ToolStripMenuItem();
            loadWordsToolStripMenuItem = new ToolStripMenuItem();
            updateAllWorldsToolStripMenuItem = new ToolStripMenuItem();
            cancelTaskToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(859, 467);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Status";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Progress";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Result";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addTaskToolStripMenuItem, cancelTaskToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(173, 68);
            // 
            // addTaskToolStripMenuItem
            // 
            addTaskToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadWordsToolStripMenuItem, updateAllWorldsToolStripMenuItem });
            addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            addTaskToolStripMenuItem.Size = new Size(172, 32);
            addTaskToolStripMenuItem.Text = "Add task";
            addTaskToolStripMenuItem.Click += addTaskToolStripMenuItem_Click;
            // 
            // loadWordsToolStripMenuItem
            // 
            loadWordsToolStripMenuItem.Name = "loadWordsToolStripMenuItem";
            loadWordsToolStripMenuItem.Size = new Size(252, 34);
            loadWordsToolStripMenuItem.Text = "Load words";
            // 
            // updateAllWorldsToolStripMenuItem
            // 
            updateAllWorldsToolStripMenuItem.Name = "updateAllWorldsToolStripMenuItem";
            updateAllWorldsToolStripMenuItem.Size = new Size(252, 34);
            updateAllWorldsToolStripMenuItem.Text = "Update all worlds";
            // 
            // cancelTaskToolStripMenuItem
            // 
            cancelTaskToolStripMenuItem.Name = "cancelTaskToolStripMenuItem";
            cancelTaskToolStripMenuItem.Size = new Size(172, 32);
            cancelTaskToolStripMenuItem.Text = "Cancel task";
            // 
            // TasksControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Name = "TasksControl";
            Size = new Size(859, 467);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addTaskToolStripMenuItem;
        private ToolStripMenuItem loadWordsToolStripMenuItem;
        private ToolStripMenuItem updateAllWorldsToolStripMenuItem;
        private ToolStripMenuItem cancelTaskToolStripMenuItem;
    }
}
