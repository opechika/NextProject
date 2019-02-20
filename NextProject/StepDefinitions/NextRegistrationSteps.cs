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
        public void WhenIEnterLastNameAs(string p0)
        {
           
        }

        [When(@"I enter email as ""(.*)""")]
        public void WhenIEnterEmailAs(string p0)
        {
            
        }

        [When(@"I enter password as ""(.*)""")]
        public void WhenIEnterPasswordAs(string p0)
        {
           
        }

        [When(@"I enter date of birth as ""(.*)""")]
        public void WhenIEnterDateOfBirthAs(string p0)
        {
            
        }

        [When(@"I enter contact telephone number as ""(.*)""")]
        public void WhenIEnterContactTelephoneNumberAs(Decimal p0)
        {
            
        }

        [When(@"I enter house no as ""(.*)""")]
        public void WhenIEnterHouseNoAs(int p0)
        {
           
        }

        [When(@"I search for ""(.*)"" as postcode")]
        public void WhenISearchForAsPostcode(string p0)
        {
           
        }

        [When(@"click on ""(.*)"" for next directory")]
        public void WhenClickOnForNextDirectory(string p0)
        {
            
        }

        [When(@"I click on register my account button")]
        public void WhenIClickOnRegisterMyAccountButton()
        {
           
        }

        [Then(@"my Next account is created")]
        public void ThenMyNextAccountIsCreated()
        {
            
        }

    }
}
