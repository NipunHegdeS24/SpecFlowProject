Feature: OrangeHRM

Test orange hrm website login functionality

@tag1
Scenario: Verify login for Orange HRM website
	Given Users is on the orange hrm login page
	When User enter the "<username>" and "<password>" in the text fields
	When User click on login button
	Then User is navigate to home page

Examples: 
| username | password |
| Admin    | admin123 |
