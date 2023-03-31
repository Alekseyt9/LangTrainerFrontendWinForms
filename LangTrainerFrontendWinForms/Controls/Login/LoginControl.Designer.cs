namespace LangTrainerFrontendWinForms.Controls.Login
{
    partial class LoginControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            _passRecoverLink = new LinkLabel();
            _registrationLink = new LinkLabel();
            panel1 = new Panel();
            _loginInternalControl = new LoginInternalControl();
            imageList1 = new ImageList(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 379F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(647, 388);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(_passRecoverLink, 0, 0);
            tableLayoutPanel5.Controls.Add(_registrationLink, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(134, 231);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(379, 157);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // _passRecoverLink
            // 
            _passRecoverLink.AutoSize = true;
            _passRecoverLink.Dock = DockStyle.Bottom;
            _passRecoverLink.Location = new Point(3, 26);
            _passRecoverLink.Name = "_passRecoverLink";
            _passRecoverLink.Size = new Size(183, 20);
            _passRecoverLink.TabIndex = 0;
            _passRecoverLink.TabStop = true;
            _passRecoverLink.Text = "Password recovery";
            _passRecoverLink.TextAlign = ContentAlignment.MiddleCenter;
            _passRecoverLink.LinkClicked += passRecoverLinkLinkClicked;
            // 
            // _registrationLink
            // 
            _registrationLink.AutoSize = true;
            _registrationLink.Dock = DockStyle.Bottom;
            _registrationLink.Location = new Point(192, 26);
            _registrationLink.Name = "_registrationLink";
            _registrationLink.Size = new Size(184, 20);
            _registrationLink.TabIndex = 1;
            _registrationLink.TabStop = true;
            _registrationLink.Text = "Registration";
            _registrationLink.TextAlign = ContentAlignment.MiddleCenter;
            _registrationLink.LinkClicked += registrationLinkLinkClicked;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(_loginInternalControl);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(134, 66);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 165);
            panel1.TabIndex = 2;
            // 
            // loginInternalControl1
            // 
            _loginInternalControl.BackColor = SystemColors.Control;
            _loginInternalControl.Dock = DockStyle.Fill;
            _loginInternalControl.Location = new Point(0, 0);
            _loginInternalControl.Margin = new Padding(0);
            _loginInternalControl.Name = "_loginInternalControl";
            _loginInternalControl.Padding = new Padding(30);
            _loginInternalControl.Size = new Size(377, 163);
            _loginInternalControl.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "view.png");
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "LoginControl";
            Size = new Size(647, 388);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private LinkLabel _passRecoverLink;
        private LinkLabel _registrationLink;
        private ImageList imageList1;
        private Panel panel1;
        private LoginInternalControl _loginInternalControl;
    }
}
