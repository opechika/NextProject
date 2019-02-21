using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NextProject.Helper;
using OpenQA.Selenium;

namespace NextProject.Pages
{
    public class RegistrationPage : BaseClass
    {
        private IWebElement title;
        private IWebElement firstName;
        private IWebElement lastName;
        private IWebElement myEmail;
        private IWebElement passWord;
        private IWebElement dateOfBirth;
        private IWebElement contactNumber;
        private IWebElement houseNumber;
        private IWebElement postCode;
        private IWebElement searchPostcode;
        private IWebElement yesToNextDirectory;
        private IWebElement noToNextDirectory;
        private IWebElement registerMyAccount;

        public void SelectTitle(string nameTitle)
        {
            Thread.Sleep(5000);
            title = GetElementById("Title");
            SelectByText(title,nameTitle);
        }

        public void EnterFirstName(string fName)
        {
            firstName = GetElementById("FirstName");
            firstName.SendKeys(fName);
        }

        public void EnterLastName(string lName)
        {
            lastName = GetElementById("LastName");
            lastName.SendKeys(lName);
        }

        public void EnterEmail(string sEmail)
        {
            myEmail = GetElementById("Email");
            myEmail.SendKeys(sEmail);
        }

        public void EnterPassword(string pWord)
        {
            passWord = GetElementById("Password");
            passWord.SendKeys(pWord);
        }

        public void EnterDateOfBirth(string Dbirth)
        {
            dateOfBirth = GetElementById("DobDate");
            dateOfBirth.SendKeys(Dbirth);
        }

        public void EnterContactTelephone(string Contact)
        {
            contactNumber = GetElementById("PhoneNumber");
            contactNumber.SendKeys(Contact);
        }

        public void EnterHouseNumber(string Hnumber)
        {
            houseNumber = GetElementById("HouseNumberOrName");
            houseNumber.SendKeys(Hnumber);
        }

        public void EnterPostCode(string Pcode)
        {
            postCode = GetElementById("Postcode");
            postCode.SendKeys(Pcode);
        }

        public void SearchForPostCode()
        {
            searchPostcode = GetElementById("SearchPostcode");
            searchPostcode.Click();
        }

        public void ClickForNextDirectory(string decision)
        {
            if (decision.ToLower() == "yes")
            {
                yesToNextDirectory = GetElementByCssSelector("[for='RequestDirYes']");
                yesToNextDirectory.Click();
            }
            else if (decision.ToLower() == "no")
            {
                noToNextDirectory = GetElementByCssSelector("[for='RequestDirNo']");
                noToNextDirectory.Click();
            }
            }

        public MyAcoountPage ClickOnRegistrationButton()
        {
            registerMyAccount = GetElementById("SignupButton");
            registerMyAccount.Click();
            return new MyAcoountPage();

        }
    }

}
