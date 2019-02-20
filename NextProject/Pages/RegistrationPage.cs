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
    }

}
