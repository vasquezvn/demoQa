using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleDemoQa;

namespace demoQa
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void UserCanLogin()
        {
            Driver.SetURL("http://www.google.co.in");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
