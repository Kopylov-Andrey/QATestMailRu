using System;
using OpenQA.Selenium;



namespace TestMailRu.WebDriver
{
    public class Browser
    {
        private static Browser currentInstance;
        private static IWebDriver driver;
        public static BrowserFactory.BrowserType currentBrowser;
        public static int InplWait;
        public static double timeoutForElement;
        public static string browser;






        private Browser()
        {
            InitParams();
            driver = BrowserFactory.GetDriver(currentBrowser, InplWait);  
        }

        private static void InitParams()
        {
            InplWait = Convert.ToInt32(Configuration.ElementTimeout);
            timeoutForElement = Convert.ToDouble(Configuration.ElementTimeout);
            browser = Configuration.Browser;
            Enum.TryParse(browser, out currentBrowser);
        }

        public static Browser Instance => currentInstance ?? (currentInstance = new Browser());



        public static void WindowMaximise()
        {
            driver.Manage().Window.Maximize();
        } 

        public static void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static IWebDriver GetDriver()
        {
            
                return driver;
            
        }

        public static void Quit()
        {
            driver.Quit();
            currentInstance = null; 
            driver = null;
            browser = null;
        }



    }
}
