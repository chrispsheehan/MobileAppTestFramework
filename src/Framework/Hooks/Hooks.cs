using BoDi;
using TechTalk.SpecFlow;

using MobileAppTests.Framework.Drivers;

namespace MobileAppTests.Framework.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [AfterScenario]
        public void AfterScenario(Driver driver)
        {
            driver.Quit();
        }
    }
}