using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;
using MarsFramework.Utils;

namespace MarsFramework.Test
{
    [Binding]
    public class ShareSkillsStepDefinitions : Driver
    {
        ShareSkill ShareSkillObj = new ShareSkill(driver);

        [When(@"User should be able to create new ShareSkill with valid '([^']*)'")]
        public void WhenUserShouldBeAbleToCreateNewShareSkill(int p0)
        {
            ShareSkillObj.EnterShareSkill(p0);
        }

        [Then(@"User should be able to create ShareSkill and get a successful '([^']*)'")]
        public void ThenUserShouldBeAbleCreateShareSkillSuccessfully(string p0)
        {
            string resultStatusNotification = ShareSkillObj.GetNotification();
            string expectedStatusNotification = p0;
            Assert.That(resultStatusNotification, Is.EqualTo(expectedStatusNotification));
        }

        [When(@"User should be able to create new ShareSkill with a Malicious Title '([^']*)'")]
        public void WhenUserShouldBeAbleToCreateNewShareSkillWithAMaliciousTitle(int p0)
        {
            ShareSkillObj.EnterShareSkillInvalidDescription(p0);
        }

        [Then(@"User should not be able to create ShareSkill and get a '([^']*)'")]
        public void ThenUserShouldNotBeAbleToCreateShareSkillAndGetA(string p0)
        {
            string resultStatusNotification = ShareSkillObj.GetNotificationInvalidEntry();
            string expectedStatusNotification = p0;
            Assert.That(resultStatusNotification, Is.EqualTo(expectedStatusNotification));
            Console.WriteLine(resultStatusNotification);
        }

        [When(@"User should be able to create new ShareSkill with an Invalid Work Sample Upload '([^']*)'")]
        public void WhenUserShouldBeAbleToCreateNewShareSkillWithAnInvalidWorkSampleUpload(int p0)
        {
            ShareSkillObj.EnterShareSkillInvalidWorkSampleFile(p0);
        }

        [Then(@"User should be able to create ShareSkill and get a '([^']*)'")]
        public void ThenUserShouldBeAbleToCreateShareSkillAndGetA(string p0)
        {
            string resultStatusNotification = ShareSkillObj.GetInvalidFileTypeNotification();
            string expectedStatusNotification = p0;
            Assert.That(resultStatusNotification, Is.EqualTo(expectedStatusNotification));
            Console.WriteLine(resultStatusNotification);
        }
    }
}
