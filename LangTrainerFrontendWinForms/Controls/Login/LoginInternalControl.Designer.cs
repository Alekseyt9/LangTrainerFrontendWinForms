namespace LangTrainerFrontendWinForms.Controls.Login
{
    partial class LoginInternalControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginInternalControl));
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
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.Size = new Size(499, 146);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.8184052F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1815987F));
            tableLayoutPanel3.Controls.Add(_loginButton, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 110);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(499, 36);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // _loginButton
            // 
            _loginButton.BackColor = Color.LimeGreen;
            _loginButton.BackgroundImageLayout = ImageLayout.None;
            _loginButton.Dock = DockStyle.Fill;
            _loginButton.FlatStyle = FlatStyle.Flat;
            _loginButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _loginButton.ForeColor = SystemColors.ButtonHighlight;
            _loginButton.Location = new Point(376, 3);
            _loginButton.Name = "_loginButton";
            _loginButton.Size = new Size(120, 30);
            _loginButton.TabIndex = 0;
            _loginButton.Text = "Login";
            _loginButton.UseVisualStyleBackColor = false;
            _loginButton.Click += loginButtonClick;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
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
            tableLayoutPanel4.Size = new Size(499, 110);
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
            label1.Text = "email:";
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
            _loginText.Size = new Size(380, 27);
            _loginText.TabIndex = 2;
            // 
            // _passwordText
            // 
            _passwordText.Dock = DockStyle.Fill;
            _passwordText.Location = new Point(116, 36);
            _passwordText.Margin = new Padding(3, 3, 0, 3);
            _passwordText.Name = "_passwordText";
            _passwordText.PasswordChar = '*';
            _passwordText.Size = new Size(350, 27);
            _passwordText.TabIndex = 3;
            // 
            // _passMaskButton
            // 
            _passMaskButton.Dock = DockStyle.Fill;
            _passMaskButton.ImageIndex = 0;
            _passMaskButton.ImageList = imageList1;
            _passMaskButton.Location = new Point(466, 35);
            _passMaskButton.Margin = new Padding(0, 2, 3, 1);
            _passMaskButton.Name = "_passMaskButton";
            _passMaskButton.Size = new Size(30, 29);
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
            // LoginInternalControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(tableLayoutPanel2);
            Name = "LoginInternalControl";
            Size = new Size(499, 146);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button _loginButton;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label2;
        private TextBox _loginText;
        private TextBox _passwordText;
        private Button _passMaskButton;
        private ImageList imageList1;
    }
}
