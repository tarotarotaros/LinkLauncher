namespace Main
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            URLTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            DescriptionTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            TitleLabel = new Label();
            URLLabel = new Label();
            DescriptionLabel = new Label();
            SaveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            SettingButton = new MaterialSkin.Controls.MaterialRaisedButton();
            WebImagePictureBox = new PictureBox();
            BootBrowserButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)WebImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // TitleTextField
            // 
            TitleTextField.Depth = 0;
            TitleTextField.Hint = "";
            TitleTextField.Location = new Point(169, 92);
            TitleTextField.Margin = new Padding(4, 10, 4, 10);
            TitleTextField.MaxLength = 32767;
            TitleTextField.MouseState = MaterialSkin.MouseState.HOVER;
            TitleTextField.Name = "TitleTextField";
            TitleTextField.PasswordChar = '\0';
            TitleTextField.SelectedText = "";
            TitleTextField.SelectionLength = 0;
            TitleTextField.SelectionStart = 0;
            TitleTextField.Size = new Size(574, 20);
            TitleTextField.TabIndex = 1;
            TitleTextField.TabStop = false;
            TitleTextField.UseSystemPasswordChar = false;
            // 
            // URLTextField
            // 
            URLTextField.Depth = 0;
            URLTextField.Hint = "";
            URLTextField.Location = new Point(169, 132);
            URLTextField.Margin = new Padding(4, 10, 4, 10);
            URLTextField.MaxLength = 32767;
            URLTextField.MouseState = MaterialSkin.MouseState.HOVER;
            URLTextField.Name = "URLTextField";
            URLTextField.PasswordChar = '\0';
            URLTextField.SelectedText = "";
            URLTextField.SelectionLength = 0;
            URLTextField.SelectionStart = 0;
            URLTextField.Size = new Size(574, 20);
            URLTextField.TabIndex = 2;
            URLTextField.TabStop = false;
            URLTextField.UseSystemPasswordChar = false;
            // 
            // DescriptionTextField
            // 
            DescriptionTextField.Depth = 0;
            DescriptionTextField.Hint = "";
            DescriptionTextField.Location = new Point(169, 172);
            DescriptionTextField.Margin = new Padding(4, 10, 4, 10);
            DescriptionTextField.MaxLength = 32767;
            DescriptionTextField.MouseState = MaterialSkin.MouseState.HOVER;
            DescriptionTextField.Name = "DescriptionTextField";
            DescriptionTextField.PasswordChar = '\0';
            DescriptionTextField.SelectedText = "";
            DescriptionTextField.SelectionLength = 0;
            DescriptionTextField.SelectionStart = 0;
            DescriptionTextField.Size = new Size(574, 20);
            DescriptionTextField.TabIndex = 3;
            DescriptionTextField.TabStop = false;
            DescriptionTextField.UseSystemPasswordChar = false;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(74, 92);
            TitleLabel.Margin = new Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(87, 16);
            TitleLabel.TabIndex = 3;
            TitleLabel.Text = "タイトル：";
            // 
            // URLLabel
            // 
            URLLabel.AutoSize = true;
            URLLabel.Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            URLLabel.Location = new Point(114, 132);
            URLLabel.Margin = new Padding(4, 0, 4, 0);
            URLLabel.Name = "URLLabel";
            URLLabel.Size = new Size(47, 16);
            URLLabel.TabIndex = 4;
            URLLabel.Text = "URL：";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(106, 172);
            DescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(55, 16);
            DescriptionLabel.TabIndex = 5;
            DescriptionLabel.Text = "説明：";
            // 
            // SaveButton
            // 
            SaveButton.Depth = 0;
            SaveButton.Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Icon = null;
            SaveButton.Location = new Point(613, 352);
            SaveButton.Margin = new Padding(4);
            SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            SaveButton.Name = "SaveButton";
            SaveButton.Primary = true;
            SaveButton.Size = new Size(130, 30);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += OnSaveButtonClicked;
            // 
            // SettingButton
            // 
            SettingButton.Depth = 0;
            SettingButton.Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SettingButton.Icon = null;
            SettingButton.Location = new Point(613, 29);
            SettingButton.Margin = new Padding(4);
            SettingButton.MouseState = MaterialSkin.MouseState.HOVER;
            SettingButton.Name = "SettingButton";
            SettingButton.Primary = true;
            SettingButton.Size = new Size(130, 30);
            SettingButton.TabIndex = 0;
            SettingButton.Text = "設定";
            SettingButton.UseVisualStyleBackColor = true;
            SettingButton.Click += OnSettingButtonClicked;
            // 
            // WebImagePictureBox
            // 
            WebImagePictureBox.BorderStyle = BorderStyle.FixedSingle;
            WebImagePictureBox.Location = new Point(169, 205);
            WebImagePictureBox.Name = "WebImagePictureBox";
            WebImagePictureBox.Size = new Size(207, 177);
            WebImagePictureBox.TabIndex = 8;
            WebImagePictureBox.TabStop = false;
            // 
            // BootBrowserButton
            // 
            BootBrowserButton.Depth = 0;
            BootBrowserButton.Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BootBrowserButton.Icon = null;
            BootBrowserButton.Location = new Point(475, 29);
            BootBrowserButton.Margin = new Padding(4);
            BootBrowserButton.MouseState = MaterialSkin.MouseState.HOVER;
            BootBrowserButton.Name = "BootBrowserButton";
            BootBrowserButton.Primary = true;
            BootBrowserButton.Size = new Size(130, 30);
            BootBrowserButton.TabIndex = 9;
            BootBrowserButton.Text = "ブラウザ起動";
            BootBrowserButton.UseVisualStyleBackColor = true;
            BootBrowserButton.Click += OnBootBrowserButtonClciked;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 395);
            Controls.Add(BootBrowserButton);
            Controls.Add(WebImagePictureBox);
            Controls.Add(SettingButton);
            Controls.Add(SaveButton);
            Controls.Add(DescriptionLabel);
            Controls.Add(URLLabel);
            Controls.Add(TitleLabel);
            Controls.Add(DescriptionTextField);
            Controls.Add(URLTextField);
            Controls.Add(TitleTextField);
            Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainView";
            Text = "LinkLauncher";
            ((System.ComponentModel.ISupportInitialize)WebImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TitleTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField URLTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField DescriptionTextField;
        private Label TitleLabel;
        private Label URLLabel;
        private Label DescriptionLabel;
        private MaterialSkin.Controls.MaterialRaisedButton SaveButton;
        private MaterialSkin.Controls.MaterialRaisedButton SettingButton;
        private PictureBox WebImagePictureBox;
        private MaterialSkin.Controls.MaterialRaisedButton BootBrowserButton;
    }
}