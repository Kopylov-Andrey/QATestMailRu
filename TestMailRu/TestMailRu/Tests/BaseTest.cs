using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMailRu.WebDriver;


namespace TestMailRu.Tests
{
    [TestClass]
    public  class BaseTest
    {
        protected static Browser Browser;

        [TestInitialize]
        public void SetUp()
        {
            Browser = Browser.Instance;
            Browser.WindowMaximise();
            Browser.NavigateTo(Configuration.StartUrl);
        }


        [TestCleanup]
        public void CleanUp()
        {
           Browser.Quit();
        }

    }
}
