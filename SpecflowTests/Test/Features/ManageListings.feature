Feature: ManageListings

Validate "Manage Listings" on ListingManagement page.
User is able to edit and delete "Listing".

Scenario: TC_015_00 Add Sharekskill temporary code - TC_015_02 Prerequisite
	When User should be able to create new ShareSkill
	Then User should be able create ShareSkill successfully

Scenario: TC_015_02 Check if the user is able to "Delete" listing
	When User should be able to click Manage Listings and Delete button
	Then User should be able to click on Yes and see a has been deleted notification
