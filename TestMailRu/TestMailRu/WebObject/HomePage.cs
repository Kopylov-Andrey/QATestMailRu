using OpenQA.Selenium;
using TestMailRu.Entities;

namespace TestMailRu.WebObject
{
    public class HomePage : BasePage
    {
        private static readonly By HomeLbl = By.XPath("//*[@id='root']/div/div[2]/div/div/div/div/form/div[2]/div[1]/div/div/div[1]/span");

        public HomePage() : base (HomeLbl, "Home Page") {}

        private readonly BaseElement buttonEnteringPassword = new BaseElement(By.XPath("//*[@id='root']/div/div[2]/div/div/div/div/form/div[2]/div[2]/div[3]/div/div/div[1]/button/span"));
        private readonly BaseElement buttonLogInAccount = new BaseElement(By.XPath("//*[@id='root']/div/div[2]/div/div/div/div/form/div[2]/div/div[3]/div/div/div[1]/div/button/span"));
        private readonly BaseElement logiEntryField = new BaseElement(By.XPath("//*[@id='root']/div/div[2]/div/div/div/div/form/div[2]/div[2]/div[1]/div/div/div/div/div/div[1]/div/input"));
        private readonly BaseElement passwordEntryField = new BaseElement(By.XPath("//*[@id='root']/div/div[2]/div/div/div/div/form/div[2]/div/div[2]/div/div/div/div/div/input"));
       


        public void LogInToMailbox(User user)
        {
           
            logiEntryField.SendKeys(user.Login);

            buttonEnteringPassword.Click();

            passwordEntryField.SendKeys(user.Password);

            buttonLogInAccount.Click();
        }

    }
}
