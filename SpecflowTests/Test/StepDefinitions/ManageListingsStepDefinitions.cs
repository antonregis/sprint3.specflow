using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;
using MarsFramework.Utils;

namespace MarsFramework.Test
{
    [Binding]
    public class ManageListingsStepDefinitions : Driver
    {
        ManageListings ManageListingsObj = new ManageListings(driver);

        [When(@"User should be able to click Manage Listings and Delete button")]
        public void WhenUserShouldBeAbleToClickManageListingsAndDeleteButton()
        {
            ManageListingsObj.DeleteShareSkill();
        }

        [Then(@"User should be able to click on Yes and see a has been deleted notification")]
        public void ThenUserShouldBeAbleToClickOnYesAndSeeAHasBeenDeletedNotification()
        {
            string resultStatusNotification = ManageListingsObj.GetNotification();
            string expectedStatusNotification = "has been deleted";
            Console.WriteLine(resultStatusNotification);
            Assert.That(resultStatusNotification.Contains(expectedStatusNotification));
        }
    }
}
