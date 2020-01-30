using OpenQA.Selenium;

namespace ConsoleDemoQa
{
    public class TestPage
    {
        public enum SideMenu
        {
            HtmlContactForm,
            KeyboardEvents,
            AutomationPracticeSwitchWindows,
        }

        #region
        //private static IWebElement HtlmContactFormLink => Driver.Instance.FindElement(By.XPath("//div[@id='sidebar']/aside[@class='widget'][2]/ul/li[1]/a"));
        private static IWebElement HtlmContactFormLink => Driver.Instance.FindElement(By.PartialLinkText("HTML contact form"));
        private static IWebElement KeyBoardEventsLink => Driver.Instance.FindElement(By.PartialLinkText("Keyboard Events"));
        private static IWebElement AutomationPracticeSwitchWindowsLink => Driver.Instance.FindElement(By.PartialLinkText("Automation Practice Switch Windows"));
        #endregion

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://demoqa.com/");
        }

        public static void GoToMenu(SideMenu option)
        {
            switch (option)
            {
                case SideMenu.HtmlContactForm:
                    HtlmContactFormLink.Click();
                    break;

                case SideMenu.KeyboardEvents:
                    KeyBoardEventsLink.Click();
                    break;

                case SideMenu.AutomationPracticeSwitchWindows:
                    AutomationPracticeSwitchWindowsLink.Click();
                    break;
            }
        }
    }
}
