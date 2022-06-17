Feature: TC_006_Profile_EarnTarget

Validate "Earn Target" on Profile page.
User is able to select and edit "Earn Target".


Scenario: TC_006_01 Check if the user is able to "Select" the Earn Target	
	When User should be able to Click on Edit Earn Target
	Then User Should be able to Select the Earn Target option successfully

Scenario Outline: TC_006_02 Check if the user is able to "Edit" the Earn Target
	When User should be able to Click on Edit Earn Target to '<option>'
	Then User Should be able to Select the Earn Target option to '<option>' successfully

	Examples: 
	| option                           |
	| Between $500 and $1000 per month |
	| More than $1000 per month        |
	
	
