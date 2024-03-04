using Domain.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace Infrastructure.Repositories
{
    public class BrowserRepository
    {
        private const string TEMP_SAVED_PATH = "./screenshot_temp.png";
        private const string CMD_EXPECTED_RESULT = "TCP         {0}         0.0.0.0:0              LISTENING";
        private const string CHROME_IP_PORT = "127.0.0.1:9222";

        public BrowserRepository()
        {

        }



        /// <summary>
        /// https://www.selenium.dev/ja/documentation/webdriver/interactions/windows/
        /// </summary>
        public WebInfo GetWebInfo()
        {
            if (!IsRunningChrome())
            {
                return WebInfo.Empty;
            }

            var options = new ChromeOptions();
            options.DebuggerAddress = CHROME_IP_PORT;
            string title;
            string url;

            using (var driver = new ChromeDriver(options))
            {
                title = driver.Title;
                url = driver.Url;

                ////スクショとして保存してみる
                if (File.Exists(TEMP_SAVED_PATH))
                {
                    File.Delete(TEMP_SAVED_PATH);
                }

                Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
                screenshot.SaveAsFile(TEMP_SAVED_PATH); // Format values are Bmp, Gif, Jpeg, Png, Tiff

            }

            var webInfo = new WebInfo(title, url, TEMP_SAVED_PATH);

            return webInfo;

        }

        /// <summary>
        /// chromeが指定アドレスで起動中かを返す
        /// </summary>
        /// <returns>true:起動中</returns>
        private bool IsRunningChrome()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "cmd";
            string command = "netstat -nao | find \":9222\"";
            processStartInfo.Arguments = "/c " + command;
            //コンソール開かない。
            processStartInfo.CreateNoWindow = true;
            //シェル機能使用しない。
            processStartInfo.UseShellExecute = false;
            //標準出力をリダイレクト。
            processStartInfo.RedirectStandardOutput = true;
            Process? cmdProcess = Process.Start(processStartInfo);
            if (cmdProcess == null)
            {
                return false;
            }

            //標準出力を全て取得。
            string res_ = cmdProcess.StandardOutput.ReadToEnd();

            return res_.Contains(string.Format(CMD_EXPECTED_RESULT, CHROME_IP_PORT));
        }
    }
}