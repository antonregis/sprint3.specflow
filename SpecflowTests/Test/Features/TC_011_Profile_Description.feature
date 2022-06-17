Feature: TC_011_Profile_Description

Validate "Description" on Profile page.
User is able to enter and edit "Description".


Scenario: TC_011_01	Check if the user is able to Enter Descripriton
	When User should be able to Click Edit Description and Enter Description
	Then User should be able to Save the Description successfully

Scenario: TC_011_02 Check if the user is able to Edit Description
	When User should be able to Edit Description
	Then User should be able to Save the Edited Description successfully

	


