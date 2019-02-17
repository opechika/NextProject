using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NextProject.Helper;
using NUnit.Framework;
using OpenQA.Selenium;


namespace NextProject.Pages
{
    public class NextHomePage : BaseClass
    {
        private IWebElement logo;
        private IWebElement accountLink;

        public void IsHomepageDisplayed()
        {
            logo = GetElementById("header-logo");
            Assert.True(logo.Displayed);
        }

        public void ClickOnMyAccountLink()
        {
            Thread.Sleep(5000);
            accountLink = GetElementByCssSelector("[data-link-id='DataLinkId']");
            accountLink.Click();
        }
    }

}
