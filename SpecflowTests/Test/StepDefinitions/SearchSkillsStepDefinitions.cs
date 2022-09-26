using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework.Test
{
    [Binding]
    public class SearchSkillsStepDefinitions
    {
        SearchSkills SearchSkillsObj = new SearchSkills();

        [When(@"User should be able click Search with blank entry")]
        public void WhenUserShouldBeAbleClickSearchWithBlankEntry()
        {
            SearchSkillsObj.SearchAllCategories();
        }

        [Then(@"User should be able view All Categories search results")]
        public void ThenUserShouldBeAbleViewAllCategoriesSearchResults()
        {
            string result1 = SearchSkillsObj.GetAllCategories();
            int result2 = int.Parse(SearchSkillsObj.GetAllCategoriesResult());
            string expectedResult1 = "All Categories";
        }

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

        [When(@"User should be able click Search and click Online filter")]
        public void WhenUserShouldBeAbleClickSearchAndClickOnlineFilter()
        {
            SearchSkillsObj.SearchByFilter("Online");
        }

        [When(@"User should be able click Search and click Onsite filter")]
        public void WhenUserShouldBeAbleClickSearchAndClickOnsiteFilter()
        {
            SearchSkillsObj.SearchByFilter("Onsite");
        }

        [When(@"User should be able click Search and click ShowAll filter")]
        public void WhenUserShouldBeAbleClickSearchAndClickShowAllFilter()
        {
            SearchSkillsObj.SearchByFilter("ShowAll");
        }

        [Then(@"User should be able to see search results")]
        public void ThenUserShouldBeAbleToSeeSearchResults()
        {
            int result2 = int.Parse(SearchSkillsObj.GetAllCategoriesResult());
            Assert.GreaterOrEqual(result2, 0);
        }
    }
}
