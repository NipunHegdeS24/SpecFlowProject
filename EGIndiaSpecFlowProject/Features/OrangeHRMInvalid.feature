Feature: OrangeHRMInvalid

Test orange hrm website In-login functionality

@tag1
Scenario: Verify login for Orange HRM website
	Given User is on the orange hrm login page
	When User enters the "<usrname>" and "<passwd>" in the text field
	When User clickss on login button
	Then User receives a invalid login message

Examples: 
| usrname | passwd |
| Ramzz   | admin  |
