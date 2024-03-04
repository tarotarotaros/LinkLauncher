using Domain.Models;
using Infrastructure;
using Infrastructure.Repositories;

namespace Main.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(IMainView mainView)
        {
            _view = mainView;
            _view.SaveButtonClicked += OnSaveButtonClicked;
            _view.SettingButtonClicked += OnSettingButtonClicked;
            _view.BootBrowserClicked += OnBootButtonClicked;

            //ブラウザ情報取得
            var browserRepository = new BrowserRepository();
            var currentWeb = browserRepository.GetWebInfo();

            DisplayWebinfo(currentWeb);
        }


        private void DisplayWebinfo(WebInfo currentWeb)
        {
            if (currentWeb.Equals(WebInfo.Empty))
            {
                _view.BootBrowserButtonVisible = true;
            }
            else
            {
                _view.BootBrowserButtonVisible = true;
                _view.Title = currentWeb.Title;
                _view.URL = currentWeb.Url;
                _view.Description = currentWeb.Description;
                _view.ImagePath = currentWeb.ImagePath;
            }
        }

        private void OnSettingButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnSaveButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnBootButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
