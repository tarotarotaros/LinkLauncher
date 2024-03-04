using DataSoldier.UI;
using Domain.Models;
using Main.CommonUI.Controls;

namespace Main.Views
{

    public interface ISettingView
    {
        event EventHandler SaveButtonClick;
        event EventHandler ViewLoad;

        string SaveDirectory { get; set; }
        string FilaName { get; set; }
        SaveType SaveType { get; set; }
    }

    public partial class SettingView : DesignedViewBase, ISettingView
    {
        public SettingView()
        {
            InitializeComponent();
        }

        public event EventHandler SaveButtonClick;
        public event EventHandler ViewLoad;

        public string SaveDirectory { get => this.SaveDirectoryLineTextField.Text; set => this.SaveDirectoryLineTextField.Text = value; }
        public string FilaName { get => this.FileNameLineTextField.Text; set => this.FileNameLineTextField.Text = value; }
        public SaveType SaveType { get => GetSaveType(); set => SetSaveType(value); }

        private void SetSaveType(SaveType value)
        {
            if (value == SaveType.MarkDown)
            {
                this.MarkDownRadioButton.Checked = true;
                return;
            }

            if (value == SaveType.Json)
            {
                this.JsonRadioButton.Checked = true;
                return;
            }

            if (value == SaveType.TSV)
            {
                this.TSVRadioButton.Checked = true;
                return;
            }

            if (value == SaveType.CSV)
            {
                this.CSVRadioButton.Checked = true;
                return;
            }

            throw new NotImplementedException();
        }

        private SaveType GetSaveType()
        {
            if (this.CSVRadioButton.Checked) return SaveType.CSV;
            if (this.TSVRadioButton.Checked) return SaveType.TSV;
            if (this.JsonRadioButton.Checked) return SaveType.Json;
            if (this.MarkDownRadioButton.Checked) return SaveType.MarkDown;

            throw new NotImplementedException();
        }

        public void OnSaveButtonClicked(object sender, EventArgs e)
        {
            SaveButtonClick(sender, e);
        }

        public void OnSelectDirectoryButtonClicked(object sender, EventArgs e)
        {
            var dlg = new FolderSelectDialog();
            dlg.Path = SaveDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
                SaveDirectory = dlg.Path;
        }

        private void OnSettingViewLoad(object sender, EventArgs e)
        {
            ViewLoad(sender, e);
        }
    }
}
