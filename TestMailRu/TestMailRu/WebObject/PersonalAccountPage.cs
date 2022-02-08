using OpenQA.Selenium;


namespace TestMailRu.WebObject
{
    public class PersonalAccountPage : BasePage
    {
        private static readonly By PersonalAccountPageLbl = By.ClassName("mt-h-c__content");

        public PersonalAccountPage() : base(PersonalAccountPageLbl, "Home Page") { }

        private readonly BaseElement buttonWriteMail = new BaseElement(By.ClassName("compose-button__txt"));
        private readonly BaseElement recipient = new BaseElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[2]/div[3]/div[2]/div/div/div[1]/div/div[2]/div/div/label/div/div/input"));
        private readonly BaseElement subjectMail = new BaseElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[2]/div[3]/div[3]/div[1]/div[2]/div/input"));
        private readonly BaseElement contentMail = new BaseElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[2]/div[3]/div[5]/div/div/div[2]/div[1]/div[1]"));
        private readonly BaseElement buttonCloseMail = new BaseElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[2]/div[2]/div/div/button[3]"));
        private readonly BaseElement buttonSaveMail = new BaseElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div[1]/span[2]/span/span"));
        private readonly BaseElement buttonMenuMail = new BaseElement(By.XPath("//*[@id='ph-whiteline']/div/div[2]/div[2]/span[3]"));
        private readonly BaseElement ExtmailButton = new BaseElement(By.XPath("//*[@id='ph-whiteline']/div/div[3]/div/div/a[3]/div[2]"));
        private readonly BaseElement ButtonDraft = new BaseElement(By.XPath("//*[@id='sideBarContent']/div/nav/a[7]"));
        private readonly BaseElement deleteDraft = new BaseElement(By.XPath("//*[@id='app-canvas']/div/div[1]/div[1]/div/div[1]/span/div[2]/table/tbody/tr/td/span[2]/div[1]/span/span"));
        private readonly BaseElement IconDraft = new BaseElement(By.XPath("//*[text()='Test mail for EPAM']/ancestor::*[6]/div[3]"));

       



        public void WriteMail(string recipient, string subject, string content)
        {
            buttonWriteMail.Click();

            this.recipient.SendKeys(recipient);
            subjectMail.SendKeys(subject);
            contentMail.SendKeys(content);
            buttonSaveMail.Click();
            buttonCloseMail.Click();

        } 


        public void ExitMail()
        {
            buttonMenuMail.Click();
            ExtmailButton.Click();
        }

        public void OpenDraft()
        {
            ButtonDraft.Click();
        }

        public void DeleteDraft()
        {
            IconDraft.Click();         
            deleteDraft.Click();
        }


    }
}
