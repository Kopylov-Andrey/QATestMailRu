using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMailRu.WebObject;
using TestMailRu.WebDriver;
using TestMailRu.Entities;
using System;

namespace TestMailRu.Tests
{
    [TestClass]
    public class TestMessegeMailru : BaseTest
    {
        private HomePage homePage;
        private PersonalAccountPage personalAccountPage;
        private User user = new User("TestUser", Configuration.Login, Configuration.Password);
        private int idSubject;

        [TestMethod]
        public void SendingLetterYourself()
        {
            Random rnd = new Random();          
            idSubject = rnd.Next(0, 10000);


            homePage = new HomePage();
            homePage.LogInToMailbox(user);
            personalAccountPage = new PersonalAccountPage();
            personalAccountPage.WriteMail(user, $"Test mail for EPAM " + idSubject, "Lorem Ipsum is simply dummy text of the printing and typesetting");
            personalAccountPage.SendMessege();
            personalAccountPage.OpenSentMessages();
            
            Assert.IsTrue(personalAccountPage.GetSubjectMail());
            
            personalAccountPage.OpenLettersYourself();
            Assert.IsTrue(personalAccountPage.GetMailYorSelf());
            personalAccountPage.ExitMail();
        }


    }
}
