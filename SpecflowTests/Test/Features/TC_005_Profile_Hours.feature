Feature: TC_005_Profile_Hours

Validate "Hours" on Profile Page.
User is able to select and edit "Hours".


Scenario: TC_005_01 Check if the user is able to "Select" the Hours
	When User should be able to Click on Hours
	Then User Should be able to Select the Hours successfully

Scenario Outline: TC_005_02 Check if the user is able to "Edit" the Hours
	When User should be able to Click on Hours to '<Option>'
	Then User Should be able to Select the Hours to '<Option>' successfully

	Examples: 
	| Option                   |
	| More than 30hours a week |
	| As needed                |
