Feature: TestParaBank2


Test login with test data parameters

Background: 
	Given User is on Regestration Page


@Regression
Scenario Outline: Regestration with test parameters
	When User Enters "<FirstName>","<LastName>","<Address>","<City>","<State>","<ZipCode>","<Phone>","<SSN>","<Username>","<Password>" and "<Confirm>"
	And User Click on Register button 
	Then User is navigated to Regestration Page

Examples: 
| FirstName | LastName | Address | City      | State     | ZipCode | Phone      | SSN  | Username | Password  | Confirm   |
| Rammu     | Bhat     | Kadri   | Mangalore | Karnataka | 575003  | 9876543210 | 1234 | rammu_25 | Admin@123 | Admin@123 |

