using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;
using MarsFramework.Utils;

namespace MarsFramework.Test
{
    [Binding]
    public class ProfileStepDefinitions : Driver
    {
        // Initializing page object
        Profile ProfileObj = new Profile(driver);

        [When(@"User should be able to Click on '([^']*)' Availability")]
        public void WhenUserShouldBeAbleToClickOnAvailability(string p0)
        {
            ProfileObj.SelectAvailability(p0);
        }

        [Then(@"User Should be able to Select '([^']*)' Availability Time successfully")]
        public void ThenUserShouldBeAbleToSelectAvailabilityTimeSuccessfully(string p0)
        {
            string result = ProfileObj.GetAvailabilityTimeValue();
            string expectedResult = p0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [When(@"User should be able to Click on Availability to '([^']*)'")]
        public void WhenUserShouldBeAbleToClickOnAvailabilityToFullTime(string p0)
        {
            ProfileObj.SelectAvailability(p0);
        }

        [Then(@"User Should be able to Edit the Availability Time to '([^']*)' successfully")]
        public void ThenUserShouldBeAbleToEditTheAvailabilityTimeToFullTimeSuccessfully(string p0)
        {
            string result = ProfileObj.GetAvailabilityTimeValue();
            string expectedResult = p0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [When(@"User should be able to Click on '([^']*)' Hours")]
        public void WhenUserShouldBeAbleToClickOnHours(string p0)
        {
            ProfileObj.SelectHours(p0); //Less than 30hours a week
        }

        [Then(@"User Should be able to Select the '([^']*)' Hours successfully")]
        public void ThenUserShouldBeAbleToSelectTheHours(string p0)
        {
            string result = ProfileObj.GetHoursValue();
            string expectedResult = p0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }


        [When(@"User should be able to Click on Hours to '([^']*)'")]
        public void WhenUserShouldBeAbleToClickOnHoursTo(string p0)
        {
            ProfileObj.SelectHours(p0);
        }

        [Then(@"User Should be able to Select the Hours to '([^']*)' successfully")]
        public void ThenUserShouldBeAbleToSelectTheHoursTo(string p0)
        {
            string result = ProfileObj.GetHoursValue();
            string expectedResult = p0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [When(@"User should be able to Click on '([^']*)' Earn Target")]
        public void WhenUserShouldBeAbleToClickOnEditEarnTarget(string p0)
        {
            ProfileObj.SelectEarnTarget(p0);
        }

        [Then(@"User Should be able to Select the '([^']*)' Earn Target successfully")]
        public void ThenUserShouldBeAbleToSelectTheEarnTargetOptionSuccessfully(string p0)
        {
            string result = ProfileObj.GetEarnTargetValue();
            string expectedResult = p0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [When(@"User should be able to Click on Edit Earn Target to '([^']*)'")]
        public void WhenUserShouldBeAbleToClickOnEditEarnTargetTo(string p0)
        {
            ProfileObj.SelectEarnTarget(p0);
        }

        [Then(@"User Should be able to Select the Earn Target option to '([^']*)' successfully")]
        public void ThenUserShouldBeAbleToSelectTheEarnTargetOptionToSuccessfully(string p0)
        {
            string result = ProfileObj.GetEarnTargetValue();
            string expectedResult = p0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [When(@"User should be able to Click Edit Description and Enter '([^']*)'")]
        public void WhenUserShouldBeAbleToClickEditDescriptionAndEnterDescription(string p0)
        {
            ProfileObj.EnterDescription(p0);
        }

        [Then(@"User should be able to Save the '([^']*)' successfully")]
        public void ThenUserShouldBeAbleToSaveTheDescriptionSuccessfully(string p0)
        {
            string result = ProfileObj.GetDescriptionValue();
            string expectedResult = p0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [When(@"User should be able to Edit '([^']*)'")]
        public void WhenUserShouldBeAbleToEditDescription(string p0)
        {
            ProfileObj.EnterDescription(p0);
        }

        [Then(@"User should be able to Save the Edited '([^']*)' successfully")]
        public void ThenUserShouldBeAbleToSaveTheEditedDescriptionSuccessfully(string p0)
        {
            string result = ProfileObj.GetDescriptionValue();
            string expectedResult = p0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}