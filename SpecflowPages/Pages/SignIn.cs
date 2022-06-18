using MarsFramework.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using static MarsFramework.Utils.CommonMethods;


namespace MarsFramework.Pages
{
    public class SignIn : Driver
    {
        public SignIn()
        {
            PageFactory.InitElements(driver, this);
        }

        #region  Initialize Web Elements 

        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion


        public void SignInStep()
        {
            NavigateToBaseUrl();
            SignIntab.Click();
            ExcelLibHelper.PopulateInCollection(ConstantHelper.ExcelDataPath, "SignIn");
            Email.SendKeys(ExcelLibHelper.ReadData(2,"Username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "Password"));
            LoginBtn.Click();
            WaitForPageToLoad();
        }
    }
}