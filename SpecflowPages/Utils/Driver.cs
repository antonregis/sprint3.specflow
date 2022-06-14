using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace MarsFramework.Utils
{
    public class Driver
    {
        // Initialize the browser
        public static IWebDriver driver { get; set; } = null!;

        public void Initialize()
        {
            // Open and maximise chrome browser
            driver = GetChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1500);
            driver.Manage().Window.Maximize();            
        }

        private IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            // options.AddArguments("--headless");

            return new ChromeDriver(ConstantHelper.DriverPath, options, TimeSpan.FromSeconds(300));
        }

        // Go to home page
        public static void NavigateToBaseUrl()
        {
            driver.Navigate().GoToUrl(ConstantHelper.BaseUrl);
        }

        // Close the browser
        public void Close()
        {
            driver.Quit();
        }
    }
}