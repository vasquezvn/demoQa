using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;

namespace ConsoleDemoQa
{
    public class HtmlContactFormCommand
    {
        private string username;
        private string lastname;
        private string country;
        private string subject;

        #region IWebElements

        private static IWebElement PageTitleTag => Driver.Instance.FindElement(By.ClassName("entry-title"));
        private static IWebElement FirstNameInputText => Driver.Instance.FindElement(By.ClassName("firstname"));
        private static IWebElement LastNameInputText => Driver.Instance.FindElement(By.Id("lname"));
        private static IWebElement CountryInputText => Driver.Instance.FindElement(By.Name("country"));
        private static ReadOnlyCollection<IWebElement> GoogleLinks => Driver.Instance.FindElements(By.PartialLinkText("Google Link"));
        private static IWebElement SubjectTextArea => Driver.Instance.FindElement(By.Id("subject"));
        private static IWebElement SubmitBtn => Driver.Instance.FindElement(By.XPath("//*[@type='submit']"));
        #endregion

        public HtmlContactFormCommand(string username)
        {
            this.username = username;
        }

        public HtmlContactFormCommand WithLastName(string lastname)
        {
            this.lastname = lastname;

            return this;
        }

        public HtmlContactFormCommand WithCountry(string country)
        {
            this.country = country;

            return this;
        }

        public HtmlContactFormCommand WithSubject(string subject)
        {
            this.subject = subject;

            return this;
        }

        public void Submit()
        {
            FirstNameInputText.SendKeys(username);
            LastNameInputText.SendKeys(lastname);
            CountryInputText.SendKeys(country);
            SubjectTextArea.SendKeys(subject);

            SubmitBtn.Click();
        }


    }
}