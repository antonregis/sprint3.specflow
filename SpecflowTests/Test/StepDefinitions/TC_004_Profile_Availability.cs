using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;


namespace MarsFramework.Test
{
    [Binding]
    public class TC_004_Profile_Availability
    {
        // Initializing page object
        Profile ProfileObj = new Profile();

        [When(@"User should be able to Click on Availability")]
        public void WhenUserShouldBeAbleToClickOnAvailability()
        {
            ProfileObj.SelectAvailability("Part Time");
        }

        [Then(@"User Should be able to Select Availability Time")]
        public void ThenUserShouldBeAbleToSelectAvailabilityTime()
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

        [Then(@"User Should be able to Edit the Availability Time to Full Time")]
        public void ThenUserShouldBeAbleToEditTheAvailabilityTimeToFullTime()
        {
            string result = ProfileObj.GetAvailabilityTimeValue();
            string expectedResult = "Full Time";
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}