Feature: Profile

TC_004_Profile_Availability
Validate "Availability" on Profile Page. 
User is able to select and edit "Availability".

TC_005_Profile_Hours
Validate "Hours" on Profile Page.
User is able to select and edit "Hours".

TC_006_Profile_EarnTarget
Validate "Earn Target" on Profile page.
User is able to select and edit "Earn Target".

TC_011_Profile_Description
Validate "Description" on Profile page.
User is able to enter and edit "Description".


Scenario Outline: TC_004_01 Check if the user is able to "Select" the Availability 
	When User should be able to Click on '<Option>' Availability
	Then User Should be able to Select '<Option>' Availability Time successfully

	Examples:
	| Option    |
	| Part Time |


Scenario Outline: TC_004_02 Check if the user is able to "Edit" the Availability
	When User should be able to Click on Availability to '<Option>'
	Then User Should be able to Edit the Availability Time to '<Option>' successfully

	Examples:
	| Option    |
	| Full Time |


Scenario Outline: TC_005_01 Check if the user is able to "Select" the Hours
	When User should be able to Click on '<Option>' Hours
	Then User Should be able to Select the '<Option>' Hours successfully

	Examples:
	| Option    |
	| Less than 30hours a week |


Scenario Outline: TC_005_02 Check if the user is able to "Edit" the Hours
	When User should be able to Click on Hours to '<Option>'
	Then User Should be able to Select the Hours to '<Option>' successfully

	Examples: 
	| Option                   |
	| More than 30hours a week |
	| As needed                |


Scenario Outline: TC_006_01 Check if the user is able to "Select" the Earn Target	
	When User should be able to Click on '<Option>' Earn Target
	Then User Should be able to Select the '<Option>' Earn Target successfully

	Examples: 
	| Option                   |
	| Less than $500 per month |


Scenario Outline: TC_006_02 Check if the user is able to "Edit" the Earn Target
	When User should be able to Click on Edit Earn Target to '<option>'
	Then User Should be able to Select the Earn Target option to '<option>' successfully

	Examples: 
	| option                           |
	| Between $500 and $1000 per month |
	| More than $1000 per month        |	


Scenario Outline: TC_011_01	Check if the user is able to Enter Description
	When User should be able to Click Edit Description and Enter '<description>'
	Then User should be able to Save the '<description>' successfully
	
	Examples: 
	| description                            |
	| Enter test description text area here. |


Scenario Outline: TC_011_02 Check if the user is able to Edit Description
	When User should be able to Edit '<description>'
	Then User should be able to Save the Edited '<description>' successfully

	Examples: 
	| description                                                                |
	| Lorem Ipsum is simply dummy text of the printing and typesetting industry. |	