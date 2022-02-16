using OpenQA.Selenium;
using TestMailRu.Entities;
using TestMailRu.WebDriver;


namespace TestMailRu.WebObject
{
    public class PersonalAccountPage : BasePage
    {
        private static readonly By PersonalAccountPageLbl = By.XPath("//*[@id='app-canvas']/div/div[1]/div[1]/div/div[1]/span/div[1]/div/div/div/a/a[1]/div/img");

        public PersonalAccountPage() : base(PersonalAccountPageLbl, "Home Page") { }

        private readonly BaseElement buttonWriteMail = new BaseElement(By.ClassName("compose-button__txt"));

        private readonly BaseElement recipient = new BaseElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[2]/div[3]/div[2]/div/div/div[1]/div/div[2]/div/div/label/div/div/input"));
        private readonly BaseElement subjectMail = new BaseElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[2]/div[3]/div[3]/div[1]/div[2]/div/input"));
        private readonly BaseElement contentMail = new BaseElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[2]/div[3]/div[5]/div/div/div[2]/div[1]/div[1]"));
        private readonly BaseElement buttonCloseMail = new BaseElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[2]/div[2]/div/div/button[3]"));
        private readonly BaseElement buttonCloseSendMail = new BaseElement(By.XPath("/html/body/div[10]/div/div/div[2]/div[2]/div/div/div[1]/span/span"));
        private readonly BaseElement buttonSaveMail = new BaseElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div[1]/span[2]/span/span"));
        private readonly BaseElement buttonMenuMail = new BaseElement(By.XPath("//*[@id='ph-whiteline']/div/div[2]/div[2]/span[3]"));
        private readonly BaseElement ExtmailButton = new BaseElement(By.XPath("//*[@id='ph-whiteline']/div/div[3]/div/div/a[3]/div[2]"));
        private readonly BaseElement ButtonDraft = new BaseElement(By.XPath("//*[@id='sideBarContent']/div/nav/a[7]"));
        private readonly BaseElement deleteDraft = new BaseElement(By.XPath("//*[@id='app-canvas']/div/div[1]/div[1]/div/div[1]/span/div[2]/table/tbody/tr/td/span[2]/div[1]/span/span"));
        private readonly BaseElement IconDraft = new BaseElement(By.XPath("//*[text()='Test mail for EPAM']/ancestor::*[6]/div[3]"));
        private readonly BaseElement buttonSend = new BaseElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div[1]/span[1]/span/span"));
        private readonly BaseElement buttonSentSessages = new BaseElement(By.XPath("//*[@id='sideBarContent']/div/nav/a[6]/div/div[2]/div"));
        private readonly BaseElement buttonLettersYourself = new BaseElement(By.XPath("//*[@id='sideBarContent']/div/nav/a[5]/div/div[2]/div"));
        private readonly BaseElement mailInSentMessege = new BaseElement(By.CssSelector("#app-canvas > div > div.application-mail > div.application-mail__overlay > div > div.application-mail__layout.application-mail__layout_main > span > div.layout__main-frame > div > div > div > div > div.letter-list.letter-list_has-letters > div > div > div > div:nth-child(1) > div > div > a.llc.llc_normal.llc_first.llc_new.llc_new-selection.js-letter-list-item.js-tooltip-direction_letter-bottom > div.llc__container > div > div.llc__item.llc__item_title > span.llc__subject > div > span"));
        private readonly BaseElement mailInYourSelfMessege = new BaseElement(By.CssSelector("#//*[@id='app-canvas']/div/div[1]/div[1]/div/div[2]/span/div[2]/div/div/div/div/div[1]/div/div/div/div[1]/div/div/a[1]/div[4]/div/div[3]/span[1]/div/span"));



        public void WriteMail(User user, string subject, string content)
        {
            buttonWriteMail.Click();

            this.recipient.SendKeys(user.Login);
            subjectMail.SendKeys(subject);
            contentMail.SendKeys(content);
        }

        public void SendMessege()
        {
            buttonSend.Click();
            buttonCloseSendMail.Click();
        }

        public void OpenSentMessages()
        {
           
            buttonSentSessages.Click();
        }

        public void OpenLettersYourself()
        {
            buttonLettersYourself.Click();
        }


        public void SaveMassege()
        {
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


        public bool GetSubjectMail()
        {

            if (mailInSentMessege != null)
            {
                return true;
            }
            else return false;
        }

        public bool GetMailYorSelf()
        {
            if (mailInYourSelfMessege != null)
            {
                return true;
            }
            else return false;
        }
    }
}
