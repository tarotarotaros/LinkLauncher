using DataSoldier.UI;

namespace Main
{

    public interface IMainView
    {
        event EventHandler SaveButtonClicked;
        event EventHandler SettingButtonClicked;
        event EventHandler BootBrowserClicked;

        string Title { get; set; }
        string URL { get; set; }
        string Description { get; set; }
        string ImagePath { set; }

        bool BootBrowserButtonVisible { set; }
    }

    public partial class MainView : DesignedViewBase, IMainView
    {
        public string Title { get => this.TitleTextField.Text; set => this.TitleTextField.Text = value; }
        public string URL { get => this.URLTextField.Text; set => this.URLTextField.Text = value; }
        public string Description { get => this.DescriptionTextField.Text; set => this.DescriptionTextField.Text = value; }
        public string ImagePath { set => this.WebImagePictureBox.ImageLocation = value; }
        public bool BootBrowserButtonVisible { set => this.BootBrowserButton.Visible = value; }

        public event EventHandler SaveButtonClicked;
        public event EventHandler SettingButtonClicked;
        public event EventHandler BootBrowserClicked;

        public MainView()
        {
            InitializeComponent();

            this.WebImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.DescriptionTextField.TabStop = true;

        }


        public void OnSaveButtonClicked(object sender, EventArgs e)
        {
            SaveButtonClicked(this, EventArgs.Empty);
        }

        public void OnSettingButtonClicked(object sender, EventArgs e)
        {
            SettingButtonClicked(this, EventArgs.Empty);
        }

        public void OnBootBrowserButtonClciked(object sender, EventArgs e)
        {
            BootBrowserClicked(this, EventArgs.Empty);
        }
    }
}