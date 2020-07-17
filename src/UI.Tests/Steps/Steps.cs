using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Xunit;

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
            bool isDisplayed = _driver.IsDisplayed("formula");

            Assert.True(isDisplayed);
        }

        [When(@"I add two and two")]
        public void WhenIAddTwoAndTwo()
        {
            _driver.ClickBtn("digit_2");
            _driver.ClickBtn("op_add");          
            _driver.ClickBtn("digit_2");
            _driver.ClickBtn("eq");                        
        }

        [Then(@"I should see four")]
        public void ThenIShouldSeeFour()
        {
            string expected = "4";

            string actual = _driver.GetContent("result_final");

            Assert.Equal(expected, actual);
        }
    }
}
