using OpenQA.Selenium;

namespace TestMailRu.WebObject
{
    public class BasePage
    {
        protected By titleLocator;
        protected string title;
        public static string titileForm;


        protected BasePage(By titleLocator, string title)
        {
            this.titleLocator  = titleLocator;
            this.title = titileForm = title;
            AssertIsOpen();
        }


        public void AssertIsOpen()
        {
            var label = new BaseElement(titleLocator, title );
            label.WaitForIsVisible();
        }
    }
}
