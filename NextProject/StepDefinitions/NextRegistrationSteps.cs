using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NextProject.Helper;
using NextProject.Pages;
using TechTalk.SpecFlow;

namespace NextProject.StepDefinitions
{
    [Binding]
    public sealed class NextRegistrationSteps :BaseClass
    {   
        NextHomePage nextHomePage = new NextHomePage(); 
        SignInPage signInPage  = new SignInPage();
        private RegistrationPage registrationPage = new RegistrationPage();
        MyAcoountPage myAcoountPage = new MyAcoountPage();
       


        [Given(@"I am on Next Homepage")]
        public void GivenIAmNextHomepage()
        {
           nextHomePage.IsHomepageDisplayed();
        }

        [Given(@"I click on my account tab link")]
        public void GivenIClickOnMyAccountTabLink()
        {
           signInPage = nextHomePage.ClickOnMyAccountLink(); 
           
        }

        [Given(@"Create a Next account page is displayed")]
        public void GivenCreateANextAccountPageIsDisplayed()
        {
            signInPage.IsSignPageDisplayed();
        }

        [Given(@"I click the continue button")]
        public void GivenIClickTheContinueButton()
        {
           registrationPage = signInPage.ClickOnContinueButton();
        }

        [When(@"I select title as ""(.*)""")]
        public void WhenISelectTitleAs(string title)
        {
          registrationPage.SelectTitle(title);  
        }

        [When(@"I enter first name as ""(.*)""")]
        public void WhenIEnterFirstNameAs(string name)
        {
          registrationPage.EnterFirstName(name);  
        }

        [When(@"I enter last name as ""(.*)""")]
        public void WhenIEnterLastNameAs(string lname)
        {
           registrationPage.EnterLastName(lname);
        }

        [When(@"I enter email as ""(.*)""")]
        public void WhenIEnterEmailAs(string email)
        {
            registrationPage.EnterEmail(email);
        }

        [When(@"I enter password as ""(.*)""")]
        public void WhenIEnterPasswordAs(string paWord)
        {
           registrationPage.EnterPassword(paWord);
        }

        [When(@"I enter date of birth as ""(.*)""")]
        public void WhenIEnterDateOfBirthAs(string dBirth)
        {
            registrationPage.EnterDateOfBirth(dBirth);
        }

        [When(@"I enter contact telephone number as ""(.*)""")]
        public void WhenIEnterContactTelephoneNumberAs(string number)
        {
           registrationPage.EnterContactTelephone(number); 
        }

        [When(@"I enter house no as ""(.*)""")]
        public void WhenIEnterHouseNoAs(string houseNumber)
        {
         registrationPage.EnterHouseNumber(houseNumber);  
        }

        [When(@"I search for ""(.*)"" as postcode")]
        public void WhenISearchForAsPostcode(string pcode)
        {
          registrationPage.EnterPostCode(pcode); 
         // registrationPage.SearchForPostCode();
        }

        [When(@"click on ""(.*)"" for next directory")]
        public void WhenClickOnForNextDirectory(string decision)
        {
          registrationPage.ClickForNextDirectory(decision);  
        }

        [When(@"I click on register my account button")]
        public void WhenIClickOnRegisterMyAccountButton()
        {
            myAcoountPage = registrationPage.ClickOnRegistrationButton();
        }

        [Then(@"my Next account is created")]
        public void ThenMyNextAccountIsCreated()
        {
            
        }

    }
}
