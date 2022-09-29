using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;
using MarsFramework.Utils;

namespace MarsFramework.Test
{
    [Binding]
    public class ManageRequestStepDefinitions : Driver
    {
        ReceivedRequest ReceivedRequestObj = new ReceivedRequest(driver);

        [When(@"User should be able to load Manage Requests page and click Accept")]
        public void WhenUserShouldBeAbleToLoadManageRequestsPageAndClickAccept()
        {
            ReceivedRequestObj.AcceptRequest();
        }        

        [Then(@"User should be able to Accept and see a Service has been updated notification")]
        public void ThenUserShouldBeAbleToAcceptAndSeeAServiceHasBeenUpdatedNotification()
        {
            string resultStatusNotification = ReceivedRequestObj.GetNotification();
            string expectedStatusNotification = "has been updated";
            Assert.That(resultStatusNotification.Contains(expectedStatusNotification));
        }

        [When(@"User should be able to load Manage Requests page and click Decline")]
        public void WhenUserShouldBeAbleToLoadManageRequestsPageAndClickDecline()
        {
            ReceivedRequestObj.DeclineRequest();
        }

        [Then(@"User should be able to Decline and see a Service has been updated notification")]
        public void ThenUserShouldBeAbleToDeclineAndSeeAServiceHasBeenUpdatedNotification()
        {
            string resultStatusNotification = ReceivedRequestObj.GetNotification();
            string expectedStatusNotification = "has been updated";
            Assert.That(resultStatusNotification.Contains(expectedStatusNotification));
        }
    }
}
