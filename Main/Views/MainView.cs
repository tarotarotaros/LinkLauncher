using DataSoldier.UI;

namespace Main
{

    public interface IMainView
    {
        event EventHandler SaveButtonClicked;
        event EventHandler SettingButtonClicked;

        string Title { get; set; }
        string URL { get; set; }
        string Description { get; set; }

        string ImagePath { set; }
    }

    public partial class MainView : DesignedViewBase, IMainView
    {
        public string Title { get => this.TitleTextField.Text; set => this.TitleTextField.Text = value; }
        public string URL { get => this.URLTextField.Text; set => this.URLTextField.Text = value; }
        public string Description { get => this.DescriptionTextField.Text; set => this.DescriptionTextField.Text = value; }
        public string ImagePath { set => this.WebImagePictureBox.ImageLocation = value; }

        public event EventHandler SaveButtonClicked;
        public event EventHandler SettingButtonClicked;

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
    }
}