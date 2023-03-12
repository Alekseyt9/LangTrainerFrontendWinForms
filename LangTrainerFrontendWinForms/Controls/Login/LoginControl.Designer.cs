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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            _loginButton = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            _loginText = new TextBox();
            _passwordText = new TextBox();
            _passMaskButton = new Button();
            imageList1 = new ImageList(components);
            tableLayoutPanel5 = new TableLayoutPanel();
            _passRecoverLink = new LinkLabel();
            _registrationLink = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 336F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(647, 388);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(155, 85);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.Size = new Size(336, 102);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.21429F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.7857151F));
            tableLayoutPanel3.Controls.Add(_loginButton, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 69);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(336, 33);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // _loginButton
            // 
            _loginButton.Location = new Point(249, 3);
            _loginButton.Name = "_loginButton";
            _loginButton.Size = new Size(84, 27);
            _loginButton.TabIndex = 0;
            _loginButton.Text = "Login";
            _loginButton.UseVisualStyleBackColor = true;
            _loginButton.Click += loginButtonClick;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(label2, 0, 1);
            tableLayoutPanel4.Controls.Add(_loginText, 1, 0);
            tableLayoutPanel4.Controls.Add(_passwordText, 1, 1);
            tableLayoutPanel4.Controls.Add(_passMaskButton, 2, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(336, 69);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 33);
            label1.TabIndex = 0;
            label1.Text = "login:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 1;
            label2.Text = "password:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _loginText
            // 
            tableLayoutPanel4.SetColumnSpan(_loginText, 2);
            _loginText.Dock = DockStyle.Fill;
            _loginText.Location = new Point(116, 3);
            _loginText.Name = "_loginText";
            _loginText.Size = new Size(217, 27);
            _loginText.TabIndex = 2;
            // 
            // _passwordText
            // 
            _passwordText.Dock = DockStyle.Fill;
            _passwordText.Location = new Point(116, 36);
            _passwordText.Margin = new Padding(3, 3, 0, 3);
            _passwordText.Name = "_passwordText";
            _passwordText.PasswordChar = '*';
            _passwordText.Size = new Size(192, 27);
            _passwordText.TabIndex = 3;
            // 
            // _passMaskButton
            // 
            _passMaskButton.Dock = DockStyle.Fill;
            _passMaskButton.ImageIndex = 0;
            _passMaskButton.ImageList = imageList1;
            _passMaskButton.Location = new Point(308, 35);
            _passMaskButton.Margin = new Padding(0, 2, 3, 1);
            _passMaskButton.Name = "_passMaskButton";
            _passMaskButton.Size = new Size(25, 29);
            _passMaskButton.TabIndex = 4;
            _passMaskButton.UseVisualStyleBackColor = true;
            _passMaskButton.Click += _passMaskButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "view.png");
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(_passRecoverLink, 0, 0);
            tableLayoutPanel5.Controls.Add(_registrationLink, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(155, 187);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(336, 201);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // _passRecoverLink
            // 
            _passRecoverLink.AutoSize = true;
            _passRecoverLink.Dock = DockStyle.Bottom;
            _passRecoverLink.Location = new Point(3, 26);
            _passRecoverLink.Name = "_passRecoverLink";
            _passRecoverLink.Size = new Size(162, 20);
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
            _registrationLink.Location = new Point(171, 26);
            _registrationLink.Name = "_registrationLink";
            _registrationLink.Size = new Size(162, 20);
            _registrationLink.TabIndex = 1;
            _registrationLink.TabStop = true;
            _registrationLink.Text = "Registration";
            _registrationLink.TextAlign = ContentAlignment.MiddleCenter;
            _registrationLink.LinkClicked += registrationLinkLinkClicked;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "LoginControl";
            Size = new Size(647, 388);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button _loginButton;
        private Label label1;
        private Label label2;
        private TextBox _loginText;
        private TextBox _passwordText;
        private TableLayoutPanel tableLayoutPanel5;
        private LinkLabel _passRecoverLink;
        private LinkLabel _registrationLink;
        private Button _passMaskButton;
        private ImageList imageList1;
    }
}
