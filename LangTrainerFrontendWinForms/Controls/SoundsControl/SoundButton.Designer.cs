namespace LangTrainerFrontendWinForms.Controls
{
    partial class SoundButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundButton));
            _button = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // _button
            // 
            _button.ImageKey = "boss.png";
            _button.ImageList = imageList1;
            _button.Location = new Point(0, 0);
            _button.Name = "_button";
            _button.Size = new Size(34, 34);
            _button.TabIndex = 1;
            _button.UseVisualStyleBackColor = true;
            _button.Click += buttonClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "reload.png");
            imageList1.Images.SetKeyName(1, "boss.png");
            imageList1.Images.SetKeyName(2, "plus.png");
            // 
            // SoundButton
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_button);
            Name = "SoundButton";
            ResumeLayout(false);
        }

        #endregion

        private Button _button;
        private ImageList imageList1;
    }
}
