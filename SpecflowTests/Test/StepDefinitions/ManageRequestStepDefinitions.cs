using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework.Test
{
    [Binding]
    public class ManageRequestStepDefinitions
    {
        ReceivedRequest ReceivedRequestObj = new ReceivedRequest();

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
