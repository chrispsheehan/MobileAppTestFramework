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

            appiumOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "ECF2BE15-1198-4E84-85DE-65007EE8FB9B");
            appiumOptions.AddAdditionalCapability("wdaLaunchTimeout", 600000);
            appiumOptions.AddAdditionalCapability("wdaConnectionTimeout", 240000);
            appiumOptions.AddAdditionalCapability("useNewWDA", false);
            appiumOptions.AddAdditionalCapability("wdaEventloopIdleDelay", 0);

            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone 11");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "13.3");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, appPath);


            // appiumOptions.AddAdditionalCapability(MobileCapabilityType.FullReset, false);
            // appiumOptions.AddAdditionalCapability(MobileCapabilityType.NoReset, true);
            // appiumOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "ECF2BE15-1198-4E84-85DE-65007EE8FB9B");
            // appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
            // appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone 11 Pro Max");
            // appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "13.3");
            // appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, appPath);
            // appiumOptions.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, 60);
            // appiumOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "XCUITest");

            // appiumOptions.AddAdditionalCapability("wdaLaunchTimeout", config.Appium.iOSSettings.WdaLaunchTimeout);
            // appiumOptions.AddAdditionalCapability("wdaConnectionTimeout", config.Appium.iOSSettings.WdaConnectionTimeout);
            // appiumOptions.AddAdditionalCapability("useNewWDA", config.Appium.iOSSettings.UseNewWDA);
            // appiumOptions.AddAdditionalCapability("wdaEventloopIdleDelay", config.Appium.iOSSettings.WdaEventloopIdleDelay);
            // appiumOptions.AddAdditionalCapability("xcodeOrgId", iOsDevice.XCodeOrgId);
            // appiumOptions.AddAdditionalCapability("xcodeSigningId", iOsDevice.XCodeSigningId);


            return new IOSDriver<IOSElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), appiumOptions);
        }
    }
}
