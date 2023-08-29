namespace Custom_Browser {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            URLBox = new TextBox();
            URLButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            WebBox = new Microsoft.Web.WebView2.WinForms.WebView2();
            DropDownMenu = new ComboBox();
            EncryptionInputLabel = new Label();
            EncryptionTextBox = new TextBox();
            EncryptionButton = new Button();
            EncryptionOutput = new Label();
            CAPCHABox = new PictureBox();
            CAPCHALabel = new Label();
            CAPCHAStringLengthBox = new TextBox();
            CAPCHALengthLabel = new Label();
            GetImageButton = new Button();
            CAPCHAInputBox = new TextBox();
            CAPCHAResultLabel = new Label();
            CAPCHAVerifyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)WebBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CAPCHABox).BeginInit();
            SuspendLayout();
            // 
            // URLBox
            // 
            URLBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            URLBox.ForeColor = SystemColors.ScrollBar;
            URLBox.Location = new Point(36, 6);
            URLBox.Name = "URLBox";
            URLBox.Size = new Size(583, 23);
            URLBox.TabIndex = 0;
            URLBox.Text = "Enter website to search for, then click search";
            URLBox.Click += URLBox_click;
            URLBox.TextChanged += URLBox_TextChanged;
            URLBox.KeyDown += URLBox_KeyDown;
            // 
            // URLButton
            // 
            URLButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            URLButton.Location = new Point(619, 6);
            URLButton.Name = "URLButton";
            URLButton.Size = new Size(73, 24);
            URLButton.TabIndex = 1;
            URLButton.Text = "Search";
            URLButton.UseVisualStyleBackColor = true;
            URLButton.Click += URLButton_Click;
            // 
            // WebBox
            // 
            WebBox.AllowExternalDrop = true;
            WebBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WebBox.CreationProperties = null;
            WebBox.DefaultBackgroundColor = Color.White;
            WebBox.Location = new Point(-3, 35);
            WebBox.Name = "WebBox";
            WebBox.Size = new Size(710, 473);
            WebBox.TabIndex = 2;
            WebBox.ZoomFactor = 1D;
            // 
            // DropDownMenu
            // 
            DropDownMenu.FormattingEnabled = true;
            DropDownMenu.Items.AddRange(new object[] { "Web Browser", "Image Verifier", "Encryption", "Stock Quote (NOT FINISHED)", "Today's weather (NOT FINISHED)" });
            DropDownMenu.Location = new Point(12, 6);
            DropDownMenu.Name = "DropDownMenu";
            DropDownMenu.Size = new Size(18, 23);
            DropDownMenu.TabIndex = 3;
            DropDownMenu.DropDown += DropDown_opened;
            DropDownMenu.SelectedIndexChanged += DropDown_SelectedIndexChanged;
            // 
            // EncryptionInputLabel
            // 
            EncryptionInputLabel.AutoSize = true;
            EncryptionInputLabel.Location = new Point(12, 79);
            EncryptionInputLabel.Name = "EncryptionInputLabel";
            EncryptionInputLabel.Size = new Size(204, 15);
            EncryptionInputLabel.TabIndex = 4;
            EncryptionInputLabel.Text = "Please enter a string to be encrypted: ";
            EncryptionInputLabel.Visible = false;
            // 
            // EncryptionTextBox
            // 
            EncryptionTextBox.Location = new Point(12, 97);
            EncryptionTextBox.Name = "EncryptionTextBox";
            EncryptionTextBox.Size = new Size(251, 23);
            EncryptionTextBox.TabIndex = 5;
            EncryptionTextBox.Visible = false;
            // 
            // EncryptionButton
            // 
            EncryptionButton.Location = new Point(269, 97);
            EncryptionButton.Name = "EncryptionButton";
            EncryptionButton.Size = new Size(75, 23);
            EncryptionButton.TabIndex = 6;
            EncryptionButton.Text = "Encrypt";
            EncryptionButton.UseVisualStyleBackColor = true;
            EncryptionButton.Visible = false;
            EncryptionButton.Click += EncryptionButton_Click;
            // 
            // EncryptionOutput
            // 
            EncryptionOutput.AutoSize = true;
            EncryptionOutput.Location = new Point(12, 125);
            EncryptionOutput.Name = "EncryptionOutput";
            EncryptionOutput.Size = new Size(51, 15);
            EncryptionOutput.TabIndex = 7;
            EncryptionOutput.Text = "Output: ";
            EncryptionOutput.Visible = false;
            // 
            // CAPCHABox
            // 
            CAPCHABox.Location = new Point(24, 207);
            CAPCHABox.Name = "CAPCHABox";
            CAPCHABox.Size = new Size(192, 47);
            CAPCHABox.TabIndex = 8;
            CAPCHABox.TabStop = false;
            CAPCHABox.Visible = false;
            // 
            // CAPCHALabel
            // 
            CAPCHALabel.AutoSize = true;
            CAPCHALabel.Location = new Point(28, 257);
            CAPCHALabel.Name = "CAPCHALabel";
            CAPCHALabel.Size = new Size(188, 15);
            CAPCHALabel.TabIndex = 9;
            CAPCHALabel.Text = "Please enter the characters above: ";
            CAPCHALabel.Visible = false;
            // 
            // CAPCHAStringLengthBox
            // 
            CAPCHAStringLengthBox.Location = new Point(111, 178);
            CAPCHAStringLengthBox.Name = "CAPCHAStringLengthBox";
            CAPCHAStringLengthBox.Size = new Size(28, 23);
            CAPCHAStringLengthBox.TabIndex = 10;
            CAPCHAStringLengthBox.Visible = false;
            // 
            // CAPCHALengthLabel
            // 
            CAPCHALengthLabel.AutoSize = true;
            CAPCHALengthLabel.Location = new Point(24, 181);
            CAPCHALengthLabel.Name = "CAPCHALengthLabel";
            CAPCHALengthLabel.Size = new Size(81, 15);
            CAPCHALengthLabel.TabIndex = 11;
            CAPCHALengthLabel.Text = "String Length:";
            CAPCHALengthLabel.Visible = false;
            // 
            // GetImageButton
            // 
            GetImageButton.Location = new Point(145, 178);
            GetImageButton.Name = "GetImageButton";
            GetImageButton.Size = new Size(71, 23);
            GetImageButton.TabIndex = 12;
            GetImageButton.Text = "Get Image";
            GetImageButton.UseVisualStyleBackColor = true;
            GetImageButton.Visible = false;
            GetImageButton.Click += CAPCHAImageGetter;
            // 
            // CAPCHAInputBox
            // 
            CAPCHAInputBox.Location = new Point(24, 275);
            CAPCHAInputBox.Name = "CAPCHAInputBox";
            CAPCHAInputBox.Size = new Size(115, 23);
            CAPCHAInputBox.TabIndex = 13;
            CAPCHAInputBox.Visible = false;
            // 
            // CAPCHAResultLabel
            // 
            CAPCHAResultLabel.AutoSize = true;
            CAPCHAResultLabel.Location = new Point(24, 301);
            CAPCHAResultLabel.Name = "CAPCHAResultLabel";
            CAPCHAResultLabel.Size = new Size(69, 15);
            CAPCHAResultLabel.TabIndex = 14;
            CAPCHAResultLabel.Text = "Placeholder";
            CAPCHAResultLabel.Visible = false;
            // 
            // CAPCHAVerifyButton
            // 
            CAPCHAVerifyButton.Location = new Point(145, 275);
            CAPCHAVerifyButton.Name = "CAPCHAVerifyButton";
            CAPCHAVerifyButton.Size = new Size(71, 23);
            CAPCHAVerifyButton.TabIndex = 15;
            CAPCHAVerifyButton.Text = "Enter";
            CAPCHAVerifyButton.UseVisualStyleBackColor = true;
            CAPCHAVerifyButton.Visible = false;
            CAPCHAVerifyButton.Click += CAPCHAResult;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 509);
            Controls.Add(CAPCHAVerifyButton);
            Controls.Add(CAPCHAResultLabel);
            Controls.Add(CAPCHAInputBox);
            Controls.Add(GetImageButton);
            Controls.Add(CAPCHALengthLabel);
            Controls.Add(CAPCHAStringLengthBox);
            Controls.Add(CAPCHALabel);
            Controls.Add(CAPCHABox);
            Controls.Add(EncryptionOutput);
            Controls.Add(EncryptionButton);
            Controls.Add(EncryptionTextBox);
            Controls.Add(EncryptionInputLabel);
            Controls.Add(DropDownMenu);
            Controls.Add(WebBox);
            Controls.Add(URLButton);
            Controls.Add(URLBox);
            Name = "Form1";
            Text = "General Purpose Form";
            ((System.ComponentModel.ISupportInitialize)WebBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CAPCHABox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox URLBox;
        private Button URLButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebBox;
        private ComboBox DropDownMenu;
        private Label EncryptionInputLabel;
        private TextBox EncryptionTextBox;
        private Button EncryptionButton;
        private Label EncryptionOutput;
        private PictureBox CAPCHABox;
        private Label CAPCHALabel;
        private TextBox CAPCHAStringLengthBox;
        private Label CAPCHALengthLabel;
        private Button GetImageButton;
        private TextBox CAPCHAInputBox;
        private Label CAPCHAResultLabel;
        private Button CAPCHAVerifyButton;
    }
}
