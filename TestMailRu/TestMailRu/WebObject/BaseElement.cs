using System;
using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestMailRu.WebDriver;

namespace TestMailRu.WebObject
{
    public  class BaseElement : IWebElement
    {
        private IWebDriver driver = Browser.GetDriver();
        protected string name;
        protected By locator;
        protected IWebElement element;

        public BaseElement(By locator, string name)
        {
            
            this.locator = locator; 
            this.name = name == "" ? GetText() : name;
        }

        public BaseElement(By locator)
        {
            this.locator = locator;
        }

        public string GetText()
        {
            WaitForIsVisible();
            return element.Text;
        }


        public IWebElement GetElement()
        {
            try
            {
                WaitForIsVisible();
                element = Browser.GetDriver().FindElement(locator);
            }
            catch (Exception)
            {
                throw;
            }
            return element;
        }


        public void WaitForIsVisible()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplay = driver.FindElement(locator);
                    return elementToBeDisplay.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
        }


       
        public void Click()
        {
            WaitForIsVisible();
            Browser.GetDriver().FindElement(locator).Click();
        }

        public void SendKeys(string text)
        {
            WaitForIsVisible();
            Browser.GetDriver().FindElement(locator).SendKeys(text);
        }

       


        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetCssValue(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetDomAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetDomProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public ISearchContext GetShadowRoot()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }



        public string TagName { get; }

        public string Text { get; }

        public bool Enabled { get; }

        public bool Selected { get; }

        public Point Location { get; }

        public Size Size { get; }

        public bool Displayed { get; }
    }
}
