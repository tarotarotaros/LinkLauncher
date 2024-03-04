namespace Main.Views
{
    partial class SettingView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SaveDirectoryLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            MarkDownRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            FileNameLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            SaveTypeGroupBox = new GroupBox();
            JsonRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            TSVRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            CSVRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            FileNameLabel = new Label();
            SaveDirectoryLabel = new Label();
            SaveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            SelectDirectoryButton = new MaterialSkin.Controls.MaterialFlatButton();
            SelectDirectoryPanel = new Panel();
            SaveTypeGroupBox.SuspendLayout();
            SelectDirectoryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SaveDirectoryLineTextField
            // 
            SaveDirectoryLineTextField.Depth = 0;
            SaveDirectoryLineTextField.Hint = "";
            SaveDirectoryLineTextField.Location = new Point(190, 90);
            SaveDirectoryLineTextField.Margin = new Padding(4, 3, 4, 3);
            SaveDirectoryLineTextField.MaxLength = 32767;
            SaveDirectoryLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            SaveDirectoryLineTextField.Name = "SaveDirectoryLineTextField";
            SaveDirectoryLineTextField.PasswordChar = '\0';
            SaveDirectoryLineTextField.SelectedText = "";
            SaveDirectoryLineTextField.SelectionLength = 0;
            SaveDirectoryLineTextField.SelectionStart = 0;
            SaveDirectoryLineTextField.Size = new Size(513, 20);
            SaveDirectoryLineTextField.TabIndex = 0;
            SaveDirectoryLineTextField.TabStop = false;
            SaveDirectoryLineTextField.UseSystemPasswordChar = false;
            // 
            // MarkDownRadioButton
            // 
            MarkDownRadioButton.AutoSize = true;
            MarkDownRadioButton.Checked = true;
            MarkDownRadioButton.Depth = 0;
            MarkDownRadioButton.Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MarkDownRadioButton.Location = new Point(9, 24);
            MarkDownRadioButton.Margin = new Padding(0);
            MarkDownRadioButton.MouseLocation = new Point(-1, -1);
            MarkDownRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            MarkDownRadioButton.Name = "MarkDownRadioButton";
            MarkDownRadioButton.Ripple = true;
            MarkDownRadioButton.Size = new Size(111, 30);
            MarkDownRadioButton.TabIndex = 1;
            MarkDownRadioButton.TabStop = true;
            MarkDownRadioButton.Text = "マークダウン";
            MarkDownRadioButton.UseVisualStyleBackColor = true;
            // 
            // FileNameLineTextField
            // 
            FileNameLineTextField.Depth = 0;
            FileNameLineTextField.Hint = "";
            FileNameLineTextField.Location = new Point(190, 157);
            FileNameLineTextField.Margin = new Padding(4, 10, 4, 10);
            FileNameLineTextField.MaxLength = 32767;
            FileNameLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            FileNameLineTextField.Name = "FileNameLineTextField";
            FileNameLineTextField.PasswordChar = '\0';
            FileNameLineTextField.SelectedText = "";
            FileNameLineTextField.SelectionLength = 0;
            FileNameLineTextField.SelectionStart = 0;
            FileNameLineTextField.Size = new Size(513, 20);
            FileNameLineTextField.TabIndex = 2;
            FileNameLineTextField.TabStop = false;
            FileNameLineTextField.UseSystemPasswordChar = false;
            // 
            // SaveTypeGroupBox
            // 
            SaveTypeGroupBox.Controls.Add(JsonRadioButton);
            SaveTypeGroupBox.Controls.Add(TSVRadioButton);
            SaveTypeGroupBox.Controls.Add(CSVRadioButton);
            SaveTypeGroupBox.Controls.Add(MarkDownRadioButton);
            SaveTypeGroupBox.Location = new Point(79, 190);
            SaveTypeGroupBox.Margin = new Padding(4, 3, 4, 3);
            SaveTypeGroupBox.Name = "SaveTypeGroupBox";
            SaveTypeGroupBox.Padding = new Padding(4, 3, 4, 3);
            SaveTypeGroupBox.Size = new Size(365, 70);
            SaveTypeGroupBox.TabIndex = 3;
            SaveTypeGroupBox.TabStop = false;
            SaveTypeGroupBox.Text = "保存方法";
            // 
            // JsonRadioButton
            // 
            JsonRadioButton.AutoSize = true;
            JsonRadioButton.Depth = 0;
            JsonRadioButton.Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            JsonRadioButton.Location = new Point(280, 24);
            JsonRadioButton.Margin = new Padding(0);
            JsonRadioButton.MouseLocation = new Point(-1, -1);
            JsonRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            JsonRadioButton.Name = "JsonRadioButton";
            JsonRadioButton.Ripple = true;
            JsonRadioButton.Size = new Size(56, 30);
            JsonRadioButton.TabIndex = 4;
            JsonRadioButton.TabStop = true;
            JsonRadioButton.Text = "Json";
            JsonRadioButton.UseVisualStyleBackColor = true;
            // 
            // TSVRadioButton
            // 
            TSVRadioButton.AutoSize = true;
            TSVRadioButton.Depth = 0;
            TSVRadioButton.Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSVRadioButton.Location = new Point(210, 24);
            TSVRadioButton.Margin = new Padding(0);
            TSVRadioButton.MouseLocation = new Point(-1, -1);
            TSVRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            TSVRadioButton.Name = "TSVRadioButton";
            TSVRadioButton.Ripple = true;
            TSVRadioButton.Size = new Size(50, 30);
            TSVRadioButton.TabIndex = 3;
            TSVRadioButton.TabStop = true;
            TSVRadioButton.Text = "TSV";
            TSVRadioButton.UseVisualStyleBackColor = true;
            // 
            // CSVRadioButton
            // 
            CSVRadioButton.AutoSize = true;
            CSVRadioButton.Depth = 0;
            CSVRadioButton.Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CSVRadioButton.Location = new Point(140, 24);
            CSVRadioButton.Margin = new Padding(0);
            CSVRadioButton.MouseLocation = new Point(-1, -1);
            CSVRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            CSVRadioButton.Name = "CSVRadioButton";
            CSVRadioButton.Ripple = true;
            CSVRadioButton.Size = new Size(50, 30);
            CSVRadioButton.TabIndex = 2;
            CSVRadioButton.TabStop = true;
            CSVRadioButton.Text = "CSV";
            CSVRadioButton.UseVisualStyleBackColor = true;
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Location = new Point(79, 157);
            FileNameLabel.Margin = new Padding(4, 0, 4, 0);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(103, 16);
            FileNameLabel.TabIndex = 4;
            FileNameLabel.Text = "ファイル名：";
            // 
            // SaveDirectoryLabel
            // 
            SaveDirectoryLabel.AutoSize = true;
            SaveDirectoryLabel.Location = new Point(31, 90);
            SaveDirectoryLabel.Margin = new Padding(4, 0, 4, 0);
            SaveDirectoryLabel.Name = "SaveDirectoryLabel";
            SaveDirectoryLabel.Size = new Size(151, 16);
            SaveDirectoryLabel.TabIndex = 5;
            SaveDirectoryLabel.Text = "保存ディレクトリ：";
            // 
            // SaveButton
            // 
            SaveButton.Depth = 0;
            SaveButton.Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Icon = null;
            SaveButton.Location = new Point(573, 230);
            SaveButton.Margin = new Padding(4);
            SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            SaveButton.Name = "SaveButton";
            SaveButton.Primary = true;
            SaveButton.Size = new Size(130, 30);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += OnSaveButtonClicked;
            // 
            // SelectDirectoryButton
            // 
            SelectDirectoryButton.Depth = 0;
            SelectDirectoryButton.Dock = DockStyle.Fill;
            SelectDirectoryButton.Icon = null;
            SelectDirectoryButton.Location = new Point(0, 0);
            SelectDirectoryButton.Margin = new Padding(4, 6, 4, 6);
            SelectDirectoryButton.MouseState = MaterialSkin.MouseState.HOVER;
            SelectDirectoryButton.Name = "SelectDirectoryButton";
            SelectDirectoryButton.Primary = false;
            SelectDirectoryButton.Size = new Size(128, 28);
            SelectDirectoryButton.TabIndex = 7;
            SelectDirectoryButton.Text = "選択";
            SelectDirectoryButton.UseVisualStyleBackColor = true;
            SelectDirectoryButton.Click += OnSelectDirectoryButtonClicked;
            // 
            // SelectDirectoryPanel
            // 
            SelectDirectoryPanel.BorderStyle = BorderStyle.FixedSingle;
            SelectDirectoryPanel.Controls.Add(SelectDirectoryButton);
            SelectDirectoryPanel.Location = new Point(573, 116);
            SelectDirectoryPanel.Name = "SelectDirectoryPanel";
            SelectDirectoryPanel.Size = new Size(130, 30);
            SelectDirectoryPanel.TabIndex = 8;
            // 
            // SettingView
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 276);
            Controls.Add(SelectDirectoryPanel);
            Controls.Add(SaveButton);
            Controls.Add(SaveDirectoryLabel);
            Controls.Add(FileNameLabel);
            Controls.Add(SaveTypeGroupBox);
            Controls.Add(FileNameLineTextField);
            Controls.Add(SaveDirectoryLineTextField);
            Font = new Font("BIZ UDゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SettingView";
            Text = "設定";
            Load += OnSettingViewLoad;
            SaveTypeGroupBox.ResumeLayout(false);
            SaveTypeGroupBox.PerformLayout();
            SelectDirectoryPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField SaveDirectoryLineTextField;
        private MaterialSkin.Controls.MaterialRadioButton MarkDownRadioButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField FileNameLineTextField;
        private GroupBox SaveTypeGroupBox;
        private Label FileNameLabel;
        private Label SaveDirectoryLabel;
        private MaterialSkin.Controls.MaterialRadioButton JsonRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton TSVRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton CSVRadioButton;
        private MaterialSkin.Controls.MaterialRaisedButton SaveButton;
        private MaterialSkin.Controls.MaterialFlatButton SelectDirectoryButton;
        private Panel SelectDirectoryPanel;
    }
}