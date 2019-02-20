using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NextProject.Helper;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NextProject.Pages
{
   public class SignInPage : BaseClass
   {
       private IWebElement signInPageIdentifier;
       private IWebElement continueButton;

       public void IsSignPageDisplayed()
       {
           signInPageIdentifier = GetElementByCssSelector(".SecondaryContainer h2");
           Assert.True(signInPageIdentifier.Displayed);
       }

       public RegistrationPage ClickOnContinueButton()
       {
           continueButton = GetElementByCssSelector(".nxbtn.primary.large.btn-register-now");
           continueButton.Click();
           return new RegistrationPage();
       }
   }
}
