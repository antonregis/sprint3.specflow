using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;


namespace MarsFramework.Test
{
    [Binding]
    public class AdditionFeatureStepDefinitions
    {
        int result;

        [When(@"Add two numbers")]
        public void WhenAddTwoNumbers()
        {
            Addition addObj = new Addition();
            result = addObj.Add(1, 2);          
        }

        [Then(@"Addition performed successfully")]
        public void ThenAdditionPerformedSuccessfully()
        {
            int expectedResult = 3;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
