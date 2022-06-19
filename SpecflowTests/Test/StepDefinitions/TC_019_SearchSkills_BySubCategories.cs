using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework.Test
{
    [Binding]
    public class TC_019_SearchSkills_BySubCategories
    {
        SearchSkills SearchSkillsObj = new SearchSkills();

        [When(@"User should be able to click on '([^']*)', Sub Category and enter '([^']*)' on Search box")]
        public void WhenUserShouldBeAbleToClickOnSubCategoryAndEnterOnSearchBox(string p0, string test)
        {
            SearchSkillsObj.SearchBySubCategory(test, p0);
        }

        [Then(@"User should be able to see '([^']*)' Search results")]
        public void ThenUserShouldBeAbleToSeeSearchResults(string p0)
        {
            int result = int.Parse(SearchSkillsObj.GetResultSubCategory(p0));
            Console.WriteLine(result);
            Assert.GreaterOrEqual(result, 0);
        }
    }
}
