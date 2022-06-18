using MarsFramework.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using static MarsFramework.Utils.CommonMethods;


namespace MarsFramework.Pages
{
    public class ManageListings : Driver
    {
        public ManageListings()
        {
            PageFactory.InitElements(driver, this);
        }


        #region Initialize Web Elements (Page Factory style)

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[3]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        public IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        //Click on Yes
        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[3]/button[2]")]
        private IWebElement yesButton { get; set; }        

        //Storing the Category
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[2]")]
        private IWebElement categoryManageListing { get; set; }

        //Storing the Title
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[3]")]
        private IWebElement titleManageListing { get; set; }

        //Storing the Description
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[4]")]
        private IWebElement descriptionManageListing { get; set; }

        //Storing the Notification
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'has been deleted')]")]
        private IWebElement notification { get; set; }

        

        #endregion


        public void DeleteShareSkill() 
        {
            manageListingsLink.Click();
            WaitForPageToLoad();
            delete.Click();
            yesButton.Click();
            WaitForElement(driver, By.XPath("//div[contains(text(),'has been deleted')]"));
        }


        public string GetCategory()
        {
            return categoryManageListing.Text;
        }

        public string GetTitle()
        {
            return titleManageListing.Text;
        }

        public string GetDescription()
        {
            return descriptionManageListing.Text;
        }

        public string GetNotification()
        {
            return notification.Text;
        }
    }
}