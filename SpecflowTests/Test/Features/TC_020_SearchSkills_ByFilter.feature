Feature: TC_020_SearchSkills_ByFilter

Validate search by "Filter" on Search Skills page.
User is able to search by "Filter".


Scenario: TC_020_01	Check if the user is able to search by Online Filter
	When User should be able click Search and click Online filter
	Then User should be able to see search results

Scenario: TC_020_02	Check if the user is able to search by Onsite Filter
	When User should be able click Search and click Onsite filter
	Then User should be able to see search results

Scenario: TC_020_03	Check if the user is able to search by ShowAll Filter
	When User should be able click Search and click ShowAll filter
	Then User should be able to see search results