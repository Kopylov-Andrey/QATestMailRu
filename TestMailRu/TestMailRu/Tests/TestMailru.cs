using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMailRu.WebObject;
using TestMailRu.WebDriver;





namespace TestMailRu.Tests
{
    [TestClass]
    public class TestMailru : BaseTest
    {
       
        private HomePage homePage;
        private PersonalAccountPage personalAccountPage;

        private string password = Configuration.Password;
        private string login = Configuration.Login;
       
        [TestMethod]
        public void TestSavingLetterInDraft()
        {
            homePage = new HomePage();
            homePage.LogInToMailbox(login, password);
            personalAccountPage = new PersonalAccountPage();
            personalAccountPage.WriteMail(login, "Test mail for EPAM", "Lorem Ipsum is simply dummy text of the printing and typesetting");
            personalAccountPage.ExitMail();
        }
        //
        [TestMethod]
        public void TestzDeletedLetterInDraft()
        {
            homePage = new HomePage();
            homePage.LogInToMailbox(login, password);
            personalAccountPage = new PersonalAccountPage();
            personalAccountPage.OpenDraft();
            personalAccountPage.DeleteDraft();
            personalAccountPage.ExitMail();
        }




    }
}
