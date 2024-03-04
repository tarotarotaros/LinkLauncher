using Domain.Models;
using Domain.Repositories;
using Main.Views;

namespace Main.Presenters
{
    public class SettingPresenter
    {
        private readonly ISettingView _view;
        private readonly IApplicationSettingRepository _applicationSettingRepository;

        public SettingPresenter(ISettingView settingView, IApplicationSettingRepository applicationSettingRepository)
        {
            _view = settingView;
            _view.ViewLoad += OnViewLoad;
            _view.SaveButtonClick += OnSaveButtonClicked;

            _applicationSettingRepository = applicationSettingRepository;
        }

        private void OnViewLoad(object? sender, EventArgs e)
        {
            var setting = _applicationSettingRepository.LoadApplicationSetting();
            _view.SaveDirectory = setting.SaveDirectoryPath;
            _view.SaveType = setting.SaveType;
            _view.FilaName = setting.SaveFileNameWithoutExtension;
        }

        private void OnSaveButtonClicked(object? sender, EventArgs e)
        {
            var setting = new ApplicationSetting(_view.SaveDirectory, _view.FilaName, _view.SaveType);
            bool result = _applicationSettingRepository.SaveApplicationSetting(setting);
        }
    }
}
