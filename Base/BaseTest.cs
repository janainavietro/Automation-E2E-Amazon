using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Automation_E2E_Amazon
{
    public class BaseTest
    {
        private static IWebDriver driver; 
        private static ChromeOptions options;
        public string UrlBase { get => "https://www.amazon.com/"; }
        public static WebDriverWait wait;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                CreateDrive();
            }
            return driver;
        }
		private static void CreateDrive()
		{
			try
			{
				options = new ChromeOptions();
				options.AddArgument("--start-maximized");
				driver = new ChromeDriver(options);
				wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
				driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
			}
			catch 
			{
				KillDriver();
			}
		}

		public static void KillDriver()
		{
			if (driver != null)
			{
				driver.Dispose();
				driver.Quit();
				driver = null;
			}
		}
	}
}