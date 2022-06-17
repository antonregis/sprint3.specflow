using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework.Test
{
    [Binding]
    public class TC_011_Profile_Description
    {
        Profile ProfileObj = new Profile();

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