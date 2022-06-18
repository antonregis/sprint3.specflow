Feature: TC_018_SearchSkills_ByAllCategories

User is able to search by "All Categories".
Validate search by "All Categories" on Search Skills page.


Scenario: TC_018_01	Check if the user is able to search by "All Categories"
	When User should be able click Search with blank entry
	Then User should be able view All Categories search results
