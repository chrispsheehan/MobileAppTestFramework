using System;
using OpenQA.Selenium;

namespace MobileAppTests.Framework.Drivers
{
    public class Driver
    {
        private IWebDriver _driver;

        public Driver()
        {
            Init();
        }

        private void Init()
        {
            _driver = InitAndroidDriver.Get();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void Quit()
        {
            _driver.Quit();
        }

        private IWebElement GetElementById(string elementUniqueId)
        {
            return _driver.FindElement(By.Id($"com.google.android.calculator:id/{elementUniqueId}"));
        }

        public bool IsDisplayed(string btnId)
        {
            return GetElementById(btnId).Displayed;
        }

        public void ClickBtn(string btnId)
        {
            GetElementById(btnId).Click();
        }

        public string GetContent(string btnId)
        {
            return GetElementById(btnId).Text;
        }
    }
}
