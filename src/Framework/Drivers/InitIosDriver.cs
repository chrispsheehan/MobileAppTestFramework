using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;

namespace MobileAppTests.Framework.Drivers
{
    public static class InitIosDriver
    {
        public static IWebDriver Get()
        {
            string appPath = PathGenerator.GetAppPath("calculator.ipa");

            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.FullReset, false);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.NoReset, true);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone 11 Pro Max");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "13.4");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, appPath);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, 60);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "XCUITest");
            return new IOSDriver<IOSElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), appiumOptions);
        }
    }
}
