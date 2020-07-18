using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

using MobileAppTests.Framework;

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
            string appPath = PathGenerator.GetAppPath("calculator.apk");

            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.FullReset, false);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.NoReset, true);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, appPath);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, 60);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "uiautomator2");
            _driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), appiumOptions);
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
