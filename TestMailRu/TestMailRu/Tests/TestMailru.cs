using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMailRu.WebObject;
using TestMailRu.WebDriver;
using TestMailRu.Entities;



namespace TestMailRu.Tests
{
    [TestClass]
    public class TestMailru : BaseTest
    {
       
        private HomePage homePage;
        private PersonalAccountPage personalAccountPage;
        private User user = new User("TestUser", Configuration.Login, Configuration.Password);



        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        // as I understood .NET CORE does not support DataSource


        [TestMethod]
        public void TestSavingLetterInDraft()
        {            
            homePage = new HomePage();
            homePage.LogInToMailbox(user);
            personalAccountPage = new PersonalAccountPage();
            personalAccountPage.WriteMail(user, "Test mail for EPAM", "Lorem Ipsum is simply dummy text of the printing and typesetting");
            personalAccountPage.SaveMassege();
            personalAccountPage.ExitMail();
        }
        
        [TestMethod]
        public void TestzDeletedLetterInDraft()
        {           
            homePage = new HomePage();
            homePage.LogInToMailbox(user);
            personalAccountPage = new PersonalAccountPage();
            personalAccountPage.OpenDraft();
            personalAccountPage.DeleteDraft();
            personalAccountPage.ExitMail();
        }

     



    }
}
