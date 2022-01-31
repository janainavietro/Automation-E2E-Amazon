using OpenQA.Selenium;

namespace Automation_E2E_Amazon.Base
{
    public class BasePage: BaseTest
    {
        private static IWebDriver driver = GetDriver();

        public void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClearById(string by)
        {
            driver.FindElement(By.Id(by)).Clear();
        }

        public void SendKeysById(string by, string text)
        {
            driver.FindElement(By.Id(by)).SendKeys(text);
        }

        public void ClickById(string by)
        {
            driver.FindElement(By.Id(by)).Click();
        }

        public bool VerifyTextExistsInsideAPath(string path, string text)
        {
            string textPath = driver.FindElement(By.XPath(path)).Text;

            return textPath.Contains(text) ? true : false;
        }

        public static void ClearCookie()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }
    }
}
