Feature: TC_019_SearchSkills_BySubCategories

Validate search by "Sub Categories" on Search Skills page.
User is able to search by "Sub Categories".


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

