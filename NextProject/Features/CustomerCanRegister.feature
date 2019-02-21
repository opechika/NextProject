Feature: CustomerCanRegister
	In order to register on Next 
	As a customer 
	I want to the ability to create a Next Account

Scenario Outline: Customer can create a Next Account 
	Given I am on Next Homepage
	And I click on my account tab link
	And Create a Next account page is displayed
	And I click the continue button 
	When I select title as "<Title>"
	And I enter first name as "<FName>" 
	And I enter last name as "<SName>"
	And I enter email as "<Email>"
	And I enter password as "<Password>"
	And I enter date of birth as "<DOB>"
	And I enter contact telephone number as "<Tphone>"
	And I enter house no as "<HNo>"
	And I search for "<PCode>" as postcode
	And click on "<Directory>" for next directory
	And I click on register my account button
	Then my Next account is created


Scenarios: 
| Title | FName    | SName   | Email                        | Password  | DOB      | Tphone      | HNo | PCode  | Directory |
| Mrs   | Michelle | Saint   | MSaint@mailinator.com        | passWord1 | 01/01/78 | 07787654321 | 21  | M400DW | No        |
| Mr    | Smith    | William | smith.william@mailinator.com | Pa55word  | 02/02/88 | 07712345678 | 12  | ol98le | Yes       |
