using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Text;


namespace MarsFramework.Utils
{
    public class CommonMethods : Driver
    {
        // For capturing screenshots
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName)
            {
                var folderLocation = (ConstantHelper.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_yyyy-MM-dd_HHmmss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }

        #region WAIT HELPERS

        public static void wait(int time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        }

        public static IWebElement WaitForElement(IWebDriver driver, By by, int timeOutinSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return (wait.Until(ExpectedConditions.ElementIsVisible(by)));
        }

        public static IWebElement WaitForElementToBeClickable(IWebDriver driver, IWebElement element, int timeOutinSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void WaitFor(string xpath, string description = null)
        {
            // description paramter is optional,
            // it is just for descirbing the element.

            WaitForElement(driver, By.XPath(xpath));
        }

        public static void WaitForPageToLoad()
        {
            String title = driver.Title;

            if (title == "Profile")
            {
                WaitFor("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span", "Description edit button");
            }
            else if (title == "ServiceListing") // ShareSkill
            {
                WaitFor("//*[@name='title']", "Title field");
                // Adding time for unexpected time delay
                Thread.Sleep(1000);
            }
            else if (title == "ListingManagement") // Manage Listings
            {
                WaitFor("//*[@id='listing-management-section']/div[2]/div[1]/div[2]", "Pagination at the bottom page");
            }
            else if (title == "Search") // Search Results
            {
                WaitFor("//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div/a/img", "any Profile image");
            }
            else if (title == "ReceivedRequest") // Search Results
            {
                Thread.Sleep(3000);
                WaitFor("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]", "first row of Received Requests table");
            }
            else
            {
                // do nothing
            }
        }

        #endregion

    }
}