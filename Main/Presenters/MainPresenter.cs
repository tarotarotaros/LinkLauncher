using Infrastructure;
using Models;

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

            //ブラウザ情報取得
            var browserRepository = new BrowserRepository();

            var currentWeb = browserRepository.GetWebInfo();

            DisplayWebinfo(currentWeb);
        }

        private void DisplayWebinfo(WebInfo currentWeb)
        {
            _view.Title = currentWeb.Title;
            _view.URL = currentWeb.Url;
            _view.Description = currentWeb.Description;
            _view.ImagePath = currentWeb.ImagePath;
        }

        private void OnSettingButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnSaveButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
