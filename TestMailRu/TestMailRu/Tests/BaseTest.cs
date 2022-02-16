using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMailRu.WebDriver;


namespace TestMailRu.Tests
{
    [TestClass]
    public  class BaseTest
    {
        protected static Browser Browser;

        //private TestContext testContext;
        //public TestContext TestContextt => testContext;

        //private TestContext testContextInstance;
        //public TestContext TestContext
        //{
        //    get { return testContextInstance; }
        //    set { testContextInstance = value; }
        //}



        // for a long time I tried to understand why it doesn't work, it turned out that.NET CORE does not support DataSource and TestContext

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
