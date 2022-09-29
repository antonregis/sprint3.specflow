Feature: ShareSkills

Validate "Manage Listings" on ListingManagement page.
User is able to edit and delete "Listing".

Scenario Outline: TC_013_01 Check if the user is able to Add ShareSkill with valid inputs
	When User should be able to create new ShareSkill with valid '<TestData>'
	Then User should be able to create ShareSkill and get a successful '<Notification>'
	
	Examples:
	| TestData | Notification                       |
	| 1        | Service Listing Added successfully |

Scenario Outline: TC_013_02 Check if the user is unable to Add ShareSkill with Malicious Title
	When User should be able to create new ShareSkill with a Malicious Title '<TestData>'
	Then User should not be able to create ShareSkill and get a '<Notification>'
	
	Examples:
	| TestData | Notification                        |
	| 2        | Please complete the form correctly. |

Scenario Outline: TC_013_03	Check if the user is able to Add ShareSkill with invalid file size and type
	When User should be able to create new ShareSkill with an Invalid Work Sample Upload '<TestData>'
	Then User should be able to create ShareSkill and get a '<Notification>'
	
	Examples:
	| TestData | Notification                                                                                            |
	| 3        | Max file size is 2 MB and supported file types are gif / jpeg / png / jpg / doc(x) / pdf / txt / xls(x) |
