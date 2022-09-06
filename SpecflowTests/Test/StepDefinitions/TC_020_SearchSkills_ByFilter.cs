using TechTalk.SpecFlow;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework.Test
{
    [Binding]
    public class TC_020_SearchSkills_ByFilter
    {
        SearchSkills SearchSkillsObj = new SearchSkills();

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
