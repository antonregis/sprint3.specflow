Feature: ManageRequest

Validate "Received Request" on ReceivedRequest page.
User is able to accept and decline "Received Requests".


Scenario: TC_016_01 Check if the user is able to Accept request
	When User should be able to load Manage Requests page and click Accept
	Then User should be able to Accept and see a Service has been updated notification

Scenario: TC_016_02 Check if the user is able to Decline request
	When User should be able to load Manage Requests page and click Decline
	Then User should be able to Decline and see a Service has been updated notification