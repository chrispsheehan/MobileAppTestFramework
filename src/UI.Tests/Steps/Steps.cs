using TechTalk.SpecFlow;
using OpenQA.Selenium;

using MobileAppTests.Framework.Drivers;

namespace MobileAppTests.UI.Tests.Steps
{
    [Binding]
    public class Steps
    {
        private readonly Driver _driver;

        public Steps(Driver driver)
        {
            _driver = driver;
        }

        [Given(@"The app has loaded and is responsive")]
        public void GivenTheAppHasLoadedAndIsResponsive()
        {

        }

        [When(@"I add two and two")]
        public void WhenIAddTwoAndTwo()
        {
            _driver.ClickByText("2");
            _driver.ClickByText("+");            
            _driver.ClickByText("2");
            _driver.ClickByText("=");                        
        }

        [Then(@"I should see four")]
        public void ThenIShouldSeeFour()
        {

        }
    }
}
