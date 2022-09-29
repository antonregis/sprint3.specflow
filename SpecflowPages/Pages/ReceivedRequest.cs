using MarsFramework.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using static MarsFramework.Utils.CommonMethods;


namespace MarsFramework.Pages
{
    public class ReceivedRequest
    {
        IWebDriver driver;
        public ReceivedRequest(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }


        #region Initialize Web Elements (Page Factory style)

        //Click on Manage Request Link
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[1]")]
        private IWebElement manageRequestsSelection { get; set; }

        //Click on Received Requests Link
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[1]/div/a[1]")]
        private IWebElement receivedRequestsOption { get; set; }
        

        //Sort by Status
        [FindsBy(How = How.XPath, Using = "//div[@id='received-request-section']/div[2]/div/table/thead/tr/th[5]")]
        private IWebElement sortByStatus { get; set; }
        //*[@id="received-request-section"]/div[2]/div[1]/table/thead/tr/th[5]

        //Click on Accept
        [FindsBy(How = How.XPath, Using = "//div[@id='received-request-section']/div[2]/div/table/tbody/tr/td[8]/button[1]")]
        private IWebElement accept { get; set; }        

        //Click on Decline
        [FindsBy(How = How.XPath, Using = "//div[@id='received-request-section']/div[2]/div/table/tbody/tr/td[8]/button[2]")]
        private IWebElement decline { get; set; }

        //Click on Complete
        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Complete')]")]
        private IWebElement complete { get; set; }



        //Storing the Notification
        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'has been updated')]")]
        private IWebElement notification { get; set; }

        #endregion


        public void AcceptRequest() 
        {
            WaitForElementToBeClickable(driver, manageRequestsSelection);
            manageRequestsSelection.Click();
            WaitForElementToBeClickable(driver, receivedRequestsOption);
            receivedRequestsOption.Click();
            WaitForElementToBeClickable(driver, sortByStatus);
            sortByStatus.Click();
            WaitForElementToBeClickable(driver, accept);
            Thread.Sleep(5000);
            accept.Click();
            WaitForElement(driver, By.XPath("//div[contains(text(), 'has been updated')]"));
        }

        public void DeclineRequest()
        {
            WaitForElementToBeClickable(driver, manageRequestsSelection);
            manageRequestsSelection.Click();
            WaitForElementToBeClickable(driver, receivedRequestsOption);
            receivedRequestsOption.Click();
            WaitForElementToBeClickable(driver, sortByStatus);
            sortByStatus.Click();
            WaitForElementToBeClickable(driver, decline);
            Thread.Sleep(5000);
            decline.Click();
            WaitForElement(driver, By.XPath("//div[contains(text(), 'has been updated')]"));
        }

        public string GetNotification()
        {
            return notification.Text;
        }
    }
}