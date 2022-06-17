Feature: TC_004_Profile_Availability

Validate "Availability" on Profile Page. 
User is able to select and edit "Availability".

Scenario: TC_004_01 Check if the user is able to "Select" the Availability 
	When User should be able to Click on Availability
	Then User Should be able to Select Availability Time successfully

Scenario: TC_004_02 Check if the user is able to "Edit" the Availability
	When User should be able to Click on Availability to Full Time
	Then User Should be able to Edit the Availability Time to Full Time successfully