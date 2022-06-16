using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;


namespace MarsFramework.Test
{
    [Binding]
    public class TC_004_Profile_AvailabilityStepDefinitions
    {
        // Initializing page object
        Profile ProfileObj = new Profile();

        [When(@"User should be able to Click on ""([^""]*)""")]
        public void WhenUserShouldBeAbleToClickOn(string availability)
        {
            ProfileObj.SelectAvailability("Part Time");
        }

        [Then(@"User Should be able to Select ""([^""]*)""")]
        public void ThenUserShouldBeAbleToSelect(string p0)
        {
            string result = ProfileObj.GetAvailabilityTimeValue();
            string expectedResult = "Part Time";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [When(@"User should be able to Click on ""([^""]*)"" to ""([^""]*)""")]
        public void WhenUserShouldBeAbleToClickOnTo(string availability, string p1)
        {
            ProfileObj.SelectAvailability("Full Time");
        }

        [Then(@"User Should be able to Edit the ""([^""]*)"" to ""([^""]*)""")]
        public void ThenUserShouldBeAbleToEditTheTo(string p0, string p1)
        {
            string result = ProfileObj.GetAvailabilityTimeValue();
            string expectedResult = "Full Time";
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}