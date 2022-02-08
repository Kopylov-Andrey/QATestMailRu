using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestMailRu.WebDriver
{
    public class BrowserFactory
    {
        public enum BrowserType
        {
            Chrome,
            Firefox
        }

        public static IWebDriver GetDriver (BrowserType type, int timeoutSec)
        {
            IWebDriver driver = null;

            switch (type)   
            { 
                case BrowserType.Chrome:
                    {
                        var service = ChromeDriverService.CreateDefaultService();
                        var option = new ChromeOptions();
                        option.AddArgument("disable-infobars");
                        driver = new ChromeDriver(service, option, TimeSpan.FromSeconds(timeoutSec));
                        break;
                    } 
                case BrowserType.Firefox:
                    {   
                        //
                        break;
                    }
                  
            }

            if(driver == null)
            {
                var service = ChromeDriverService.CreateDefaultService();
                var option = new ChromeOptions();
                option.AddArgument("disable-infobars");
                driver = new ChromeDriver(service, option, TimeSpan.FromSeconds(timeoutSec));
            }

            return driver; 
        }


    }
}
