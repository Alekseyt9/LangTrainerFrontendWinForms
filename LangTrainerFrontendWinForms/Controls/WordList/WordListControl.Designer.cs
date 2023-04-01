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
            trainingStartShort1 = new Training.TrainingStartShort();
            accordion1 = new Opulos.Core.UI.Accordion();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(trainingStartShort1, 0, 1);
            tableLayoutPanel1.Controls.Add(accordion1, 0, 3);
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
            // accordion1
            // 
            accordion1.AddResizeBars = true;
            accordion1.AllowMouseResize = true;
            accordion1.AnimateCloseEffect = Opulos.Core.UI.AnimateWindowFlags.VerticalNegative | Opulos.Core.UI.AnimateWindowFlags.Hide | Opulos.Core.UI.AnimateWindowFlags.Slide;
            accordion1.AnimateCloseMillis = 300;
            accordion1.AnimateOpenEffect = Opulos.Core.UI.AnimateWindowFlags.VerticalPositive | Opulos.Core.UI.AnimateWindowFlags.Show | Opulos.Core.UI.AnimateWindowFlags.Slide;
            accordion1.AnimateOpenMillis = 300;
            accordion1.AutoFixDockStyle = true;
            accordion1.AutoScroll = true;
            accordion1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            accordion1.CheckBoxFactory = null;
            accordion1.CheckBoxMargin = new Padding(0);
            accordion1.ContentBackColor = null;
            accordion1.ContentMargin = null;
            accordion1.ContentPadding = new Padding(5);
            accordion1.ControlBackColor = null;
            accordion1.ControlMinimumHeightIsItsPreferredHeight = true;
            accordion1.ControlMinimumWidthIsItsPreferredWidth = true;
            accordion1.Dock = DockStyle.Fill;
            accordion1.DownArrow = null;
            accordion1.FillHeight = true;
            accordion1.FillLastOpened = false;
            accordion1.FillModeGrowOnly = false;
            accordion1.FillResetOnCollapse = false;
            accordion1.FillWidth = true;
            accordion1.GrabCursor = Cursors.SizeNS;
            accordion1.GrabRequiresPositiveFillWeight = true;
            accordion1.GrabWidth = 6;
            accordion1.GrowAndShrink = true;
            accordion1.Insets = new Padding(0);
            accordion1.Location = new Point(3, 93);
            accordion1.Name = "accordion1";
            accordion1.OpenOnAdd = false;
            accordion1.OpenOneOnly = false;
            accordion1.ResizeBarFactory = null;
            accordion1.ResizeBarsAlign = 0.5D;
            accordion1.ResizeBarsArrowKeyDelta = 10;
            accordion1.ResizeBarsFadeInMillis = 800;
            accordion1.ResizeBarsFadeOutMillis = 800;
            accordion1.ResizeBarsFadeProximity = 30;
            accordion1.ResizeBarsFill = 1D;
            accordion1.ResizeBarsKeepFocusAfterMouseDrag = false;
            accordion1.ResizeBarsKeepFocusIfControlOutOfView = true;
            accordion1.ResizeBarsKeepFocusOnClick = true;
            accordion1.ResizeBarsMargin = null;
            accordion1.ResizeBarsMinimumLength = 50;
            accordion1.ResizeBarsStayInViewOnArrowKey = true;
            accordion1.ResizeBarsStayInViewOnMouseDrag = true;
            accordion1.ResizeBarsStayVisibleIfFocused = true;
            accordion1.ResizeBarsTabStop = true;
            accordion1.ShowPartiallyVisibleResizeBars = false;
            accordion1.ShowToolMenu = true;
            accordion1.ShowToolMenuOnHoverWhenClosed = false;
            accordion1.ShowToolMenuOnRightClick = true;
            accordion1.ShowToolMenuRequiresPositiveFillWeight = false;
            accordion1.Size = new Size(679, 501);
            accordion1.TabIndex = 4;
            accordion1.UpArrow = null;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Training.TrainingStartShort trainingStartShort1;
        private Opulos.Core.UI.Accordion accordion1;
    }
}
