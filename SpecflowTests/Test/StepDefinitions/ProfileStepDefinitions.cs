using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;


namespace MarsFramework.Test
{
    [Binding]
    public class ProfileStepDefinitions
    {
        // Initializing page object
        Profile ProfileObj = new Profile();

        [When(@"User should be able to Click on Availability")]
        public void WhenUserShouldBeAbleToClickOnAvailability()
        {
            ProfileObj.SelectAvailability("Part Time");
        }

        [Then(@"User Should be able to Select Availability Time successfully")]
        public void ThenUserShouldBeAbleToSelectAvailabilityTimeSuccessfully()
        {
            string result = ProfileObj.GetAvailabilityTimeValue();
            string expectedResult = "Part Time";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [When(@"User should be able to Click on Availability to Full Time")]
        public void WhenUserShouldBeAbleToClickOnAvailabilityToFullTime()
        {
            ProfileObj.SelectAvailability("Full Time");
        }

        [Then(@"User Should be able to Edit the Availability Time to Full Time successfully")]
        public void ThenUserShouldBeAbleToEditTheAvailabilityTimeToFullTimeSuccessfully()
        {
            string result = ProfileObj.GetAvailabilityTimeValue();
            string expectedResult = "Full Time";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [When(@"User should be able to Click on Hours")]
        public void WhenUserShouldBeAbleToClickOnHours()
        {
            ProfileObj.SelectHours("Less than 30hours a week");
        }

        [Then(@"User Should be able to Select the Hours successfully")]
        public void ThenUserShouldBeAbleToSelectTheHours()
        {
            string result = ProfileObj.GetHoursValue();
            string expectedResult = "Less than 30hours a week";
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

        [When(@"User should be able to Click on Edit Earn Target")]
        public void WhenUserShouldBeAbleToClickOnEditEarnTarget()
        {
            ProfileObj.SelectEarnTarget("Less than $500 per month");
        }

        [Then(@"User Should be able to Select the Earn Target option successfully")]
        public void ThenUserShouldBeAbleToSelectTheEarnTargetOptionSuccessfully()
        {
            string result = ProfileObj.GetEarnTargetValue();
            string expectedResult = "Less than $500 per month";
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

        [When(@"User should be able to Click Edit Description and Enter Description")]
        public void WhenUserShouldBeAbleToClickEditDescriptionAndEnterDescription()
        {
            ProfileObj.EnterDescription("Enter test description text area here.");
        }

        [Then(@"User should be able to Save the Description successfully")]
        public void ThenUserShouldBeAbleToSaveTheDescriptionSuccessfully()
        {
            string result = ProfileObj.GetDescriptionValue();
            string expectedResult = "Enter test description text area here.";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [When(@"User should be able to Edit Description")]
        public void WhenUserShouldBeAbleToEditDescription()
        {
            ProfileObj.EnterDescription("Lorem Ipsum is simply dummy text of the printing and typesetting industry.");
        }

        [Then(@"User should be able to Save the Edited Description successfully")]
        public void ThenUserShouldBeAbleToSaveTheEditedDescriptionSuccessfully()
        {
            string result = ProfileObj.GetDescriptionValue();
            string expectedResult = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}