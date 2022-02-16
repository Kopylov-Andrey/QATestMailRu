using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMailRu.WebObject;
using TestMailRu.WebDriver;
using TestMailRu.Entities;

namespace TestMailRu.Tests
{
    [TestClass]
    public class TestMessegeMailru : BaseTest
    {
        private HomePage homePage;
        private PersonalAccountPage personalAccountPage;
        private User user = new User("TestUser", Configuration.Login, Configuration.Password);

        [TestMethod]
        public void SendingLetterYourself()
        {
            homePage = new HomePage();
            homePage.LogInToMailbox(user);
            personalAccountPage = new PersonalAccountPage();
            personalAccountPage.WriteMail(user, "Test mail for EPAM", "Lorem Ipsum is simply dummy text of the printing and typesetting");
            personalAccountPage.SendMessege();
            personalAccountPage.OpenSentMessages();
            //Assert.AreEqual($"Self: " + "Test mail for EPAM", personalAccountPage.GetSubjectMail());
            Assert.IsTrue(personalAccountPage.GetSubjectMail());

            personalAccountPage.OpenLettersYourself();
            Assert.IsTrue(personalAccountPage.GetMailYorSelf());
            personalAccountPage.ExitMail();
        }


    }
}
