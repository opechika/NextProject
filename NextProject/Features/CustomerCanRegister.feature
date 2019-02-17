Feature: CustomerCanRegister
	In order to register on Next 
	As a customer 
	I want to the ability to create a Next Account

Scenario Outline: Customer can create a Next Account 
	Given I am on Next Homepage
	And I click on my account tab link
	And Create a Next account page is displayed
	And I click the continue button 
	When I select title as "Mr"
	And I enter first name as "Smith" 
	And I enter last name as "William"
	And I enter email as "smith.william@mailinator.com"
	And I enter password as "Pa55word"
	And I enter date of birth as "02/02/88"
	And I enter contact telephone number as "07712345678"
	And I enter house no as "12"
	And I search for "OL98LE" as postcode
	And click on "Yes" for next directory
	And I click on register my account button
	Then my Next account is created


Scenarios: 
| Title | FName    | SName   | Email                        | Password | DOB      | Tphone      | HNo | PCode  | Directory |
| Mrs   | Michelle | Saint   | MSaint@mailinator.com        | passWord | 01/01/78 | 07787654321 | 21  | M40ODW | No        |
| Mr    | Smith    | William | smith.william@mailinator.com | Pa55word | 02/02/88 | 07712345678 | 12  | ol98le | Yes       |
