using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleDemoQa;

namespace demoQa
{
    [TestClass]
    public class SubmitHtmlformTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void SubmitHtmlContactForm()
        {
            TestPage.GoTo();
            TestPage.GoToMenu(TestPage.SideMenu.HtmlContactForm);

            HtmlContactFormPage.SubmitFormAs(Helper.GetRandomString(7))
                .WithLastName(Helper.GetRandomString(9))
                .WithCountry(Helper.GetRandomString(5))
                .WithSubject(Helper.GetRandomString(50))
                .Submit();
        }

        [TestCleanup]
        public void closeBrowser()
        {
            Driver.Close();
        }
    }
}
