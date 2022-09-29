Feature: SearchSkills

TC_018_SearchSkills_ByAllCategories
User is able to search by "All Categories".
Validate search by "All Categories" on Search Skills page.

TC_019_SearchSkills_BySubCategories
Validate search by "Sub Categories" on Search Skills page.
User is able to search by "Sub Categories".

TC_020_SearchSkills_ByFilter
Validate search by "Filter" on Search Skills page.
User is able to search by "Filter".

Scenario: TC_018_01	Check if the user is able to search by "All Categories"
	When User should be able click Search with blank entry
	Then User should be able view All Categories search results

Scenario Outline: TC_019_01	Check if the user is able to search by Sub Category	
	When User should be able to click on '<category>', Sub Category and enter '<skillToSearch>' on Search box
	Then User should be able to see '<subCategory>' Search results

	Examples: 
	| skillToSearch | category              | subCategory                 |
	| test          | Graphics & Design     | Book & Album covers         |
	| test          | Digital Marketing     | Social Media Marketing      |
	| test          | Writing & Translation | Proof Reading & Editing     |
	| test          | Video & Animation     | Lyric & Music Videos        |
	| test          | Music & Audio         | Voice Over                  |
	| test          | Programming & Tech    | QA                          |
	| test          | Business              | Business Tips               |
	| test          | Fun & Lifestyle       | Health, Nutrition & Fitness |

Scenario: TC_020_01	Check if the user is able to search by Online Filter
	When User should be able click Search and click Online filter
	Then User should be able to see search results

Scenario: TC_020_02	Check if the user is able to search by Onsite Filter
	When User should be able click Search and click Onsite filter
	Then User should be able to see search results

Scenario: TC_020_03	Check if the user is able to search by ShowAll Filter
	When User should be able click Search and click ShowAll filter
	Then User should be able to see search results