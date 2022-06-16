using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework.Test
{
    [Binding]
    public class TC_005_Profile_Hours
    {
        // Initializing page object
        Profile ProfileObj = new Profile();

        [When(@"User should be able to Click on Hours")]
        public void WhenUserShouldBeAbleToClickOnHours()
        {
            ProfileObj.SelectHours("Less than 30hours a week");
        }

        [Then(@"User Should be able to Select the Hours")]
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

        [Then(@"User Should be able to Select the Hours to '([^']*)'")]
        public void ThenUserShouldBeAbleToSelectTheHoursTo(string p0)
        {
            string result = ProfileObj.GetHoursValue();
            string expectedResult = p0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
