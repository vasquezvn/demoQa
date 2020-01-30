namespace ConsoleDemoQa
{
    public class HtmlContactFormPage
    {

        public static HtmlContactFormCommand SubmitFormAs(string username)
        {
            return new HtmlContactFormCommand(username);
        }
    }
}
