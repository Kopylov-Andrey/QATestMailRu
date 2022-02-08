using OpenQA.Selenium;

namespace TestMailRu.WebObject
{
    public class HomePage : BasePage
    {
        private static readonly By HomeLbl = By.Name("clb31774563");

        public HomePage() : base (HomeLbl, "Home Page") {}

        private readonly BaseElement buttonEnteringPassword = new BaseElement(By.XPath("//*[@id='mailbox']/form[1]/button[1]"));
        private readonly BaseElement buttonLogInAccount = new BaseElement(By.XPath("//*[@id='mailbox']/form[1]/button[2]"));
        private readonly BaseElement logiEntryField = new BaseElement(By.XPath("//*[@id='mailbox']/form[1]/div[1]/div[2]/input"));
        private readonly BaseElement passwordEntryField = new BaseElement(By.XPath("//*[@id='mailbox']/form[1]/div[2]/input"));
    
        public void LogInToMailbox(string login, string password)
        {
            logiEntryField.SendKeys(login);

            buttonEnteringPassword.Click();

            passwordEntryField.SendKeys(password);

            buttonLogInAccount.Click();
        }

    }
}
