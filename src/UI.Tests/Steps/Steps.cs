using TechTalk.SpecFlow;
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
            _driver.CreateBackground();
        }

        [When(@"I add two and two")]
        public void WhenIAddTwoAndTwo()
        {
            _driver.ExecuteAction();
        }

        [Then(@"I should see four")]
        public void ThenIShouldSeeFour()
        {
            _driver.CheckCondition();
        }
    }
}
