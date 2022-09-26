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

Scenario: TC_004_01 Check if the user is able to "Select" the Availability 
	When User should be able to Click on Availability
	Then User Should be able to Select Availability Time successfully

Scenario: TC_004_02 Check if the user is able to "Edit" the Availability
	When User should be able to Click on Availability to Full Time
	Then User Should be able to Edit the Availability Time to Full Time successfully

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

Scenario: TC_011_01	Check if the user is able to Enter Descripriton
	When User should be able to Click Edit Description and Enter Description
	Then User should be able to Save the Description successfully

Scenario: TC_011_02 Check if the user is able to Edit Description
	When User should be able to Edit Description
	Then User should be able to Save the Edited Description successfully