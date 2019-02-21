using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NextProject.Helper;
using TechTalk.SpecFlow;

namespace NextProject.Hooks
{
    [Binding]
    public sealed class NextHooks : BaseClass
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");
            LaunchUrl("https://www.next.co.uk/");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();   
        }
    }
}
