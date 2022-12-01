using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace MaybeThisTime_v2
{
    public class Base
    {
        String browserName;

        public static IWebDriver driver;

        [SetUp]

        public void StartBrowser()
        {

            //browserName = System.Configuration.ConfigurationManager.AppSettings["browser"];

            browserName = "Chrome";
            //TestContext.Progress.WriteLine("browserName: " + browserName);

            InitBrowser(browserName);




            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);





            driver.Manage().Window.Maximize();
            // https://www.storylane.io/request-demo
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
        }

        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {

                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

            }
        }

        [TearDown]

        public void AfterTest()
        {

            //extent.Flush();
            //driver.Quit();

        }
    }
}
