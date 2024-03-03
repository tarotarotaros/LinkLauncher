using Main.Presenters;

namespace Main
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var mainView = new MainView();
            var mainPresenter = new MainPresenter(mainView);

            Application.Run(mainView);
        }
    }
}