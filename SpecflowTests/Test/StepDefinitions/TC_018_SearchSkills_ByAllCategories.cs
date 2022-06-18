using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework.Test
{
    [Binding]
    public class TC_018_SearchSkills_ByAllCategories
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
    }
}
