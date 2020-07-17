using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

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
            string basePath = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("src"));

            string appBasePath = Path.Combine(basePath, "apps");

            string appPath = Path.Combine(appBasePath, "calculator.apk");

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

        public void ClickByText(string text)
        {
            foreach (IWebElement webElement in _driver.FindElements(By.XPath("//*")))
            {
                if (webElement.Text == text)
                {
                    webElement.Click();

                    break;
                }
            }
        }
    }
}
