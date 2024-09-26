Feature: TestParaBankLogin

Test login with tests data parameters

@Sanity
Scenario: Regestrations with test parameters
	Given Users is on the parabank login page
	When User enter "<Username>"and"<Password>"
	And User Clicks on Login button 
	Then User is navigate to home Page

Examples: 
| username | password  |
|Rammu_Bhat| admin123  |