using Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Infrastructure
{
    public class BrowserRepository
    {
        private const string TEMP_SAVED_PATH = "./screenshot_temp.png";

        public BrowserRepository()
        {
            
        }


        /// <summary>
        /// https://www.selenium.dev/ja/documentation/webdriver/interactions/windows/
        /// </summary>
        public WebInfo GetWebInfo()
        {
            var options = new ChromeOptions();
            options.DebuggerAddress = "127.0.0.1:9222";
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
    }
}