using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework.Test
{
    [Binding]
    public class TC_006_Profile_EarnTarget
    {
        // Initializing page object
        Profile ProfileObj = new Profile();

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

    }
}
