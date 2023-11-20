using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports.Reporter;
using MaybeThisTime_v2.testDataJSON;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;
using System.IO;
using System.Security.AccessControl;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace MaybeThisTime_v2.utilities
{
    public class Base
    {
        public ExtentReports extent;
        public ExtentTest test;
        String browserName;
        String webAddress;

        //public static IWebDriver driver;
        //public ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        public ThreadLocal<IWebDriver> driver = new();
        
        [OneTimeSetUp]
        public void SetUp()
        {
            // ExtentHtmlReports = ExtentSparkReporter 
            // https://stackoverflow.com/questions/66422304/extenthtmlreporter-class-cant-be-imported-with-extentreports-5-0-6-version

            //permistion 
            /*
            TestContext.Progress.WriteLine("--   start --");
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            TestContext.Progress.WriteLine("projectDirectory: " + projectDirectory);
            //String projectDirectory = "C:\\AutoTest\\ExtentReportsWebTestsResults";

            //---------

            //----------


            String reportPath = projectDirectory; // + "\\index.html";
            var htmlReporter = new ExtentSparkReporter(projectDirectory);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name", "Local host");
            extent.AddSystemInfo("Enviroment", "QA");
            extent.AddSystemInfo("Username", "Name Lastname dev");
            */

            
            //String destinationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ExtentReportsWebTestsResults");

            //String projectDirectory = "C:\\AutoTest\\ExtentReportsWebTestsResults";
            String projectDirectory = "C:\\AutoTest";
           //String reportPath = projectDirectory + "//index.html";
            String reportPath = projectDirectory + "\\index.html";
            TestContext.Progress.WriteLine("reportPath: " + reportPath);
            var htmlReporter = new ExtentSparkReporter(projectDirectory);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name", "Local host");
            
        }




        [SetUp]



        public void StartBrowser()
        {
            //IWebDriver webDriver = GetDriver();
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);

            // browser name -> start
            browserName = TestContext.Parameters["browserName"];

            if (browserName == null)
            {
                browserName = ConfigurationManager.AppSettings["browser"];
            }
            // browser name <- end

            // open browser -> start
            InitBrowser(browserName);

            //driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //driver.Value.Manage().Window.Maximize();
            GetDriver().Manage().Window.Maximize();
            // open browser <- end

            // browser address -> start
            webAddress = TestContext.Parameters["webAddress"];

            if (webAddress == null)
            {
                webAddress = ConfigurationManager.AppSettings["webAddress"];
            }

            //driver.Value.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            //driver.Value.Url = webAddress;
            GetDriver().Url = webAddress;
            // browser address <- end
        }


        public IWebDriver GetDriver()
        {
            return driver.Value;
        }

        public void InitBrowser(string browserName)
        {
            //IWebDriver webDriver = GetDriver();

            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    //driver.Value = new FirefoxDriver();
                    driver.Value = new FirefoxDriver();
                    break;

                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver.Value = new ChromeDriver();
                    break;

                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver.Value = new EdgeDriver();
                    break;
            }
        }


        public static JsonReader getDataParser()
        {
            return new JsonReader();
        }


        [TearDown]
        public void AfterTest()
        {
            //IWebDriver webDriver = GetDriver();
            var statusOfTest = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;

            DateTime time = DateTime.Now;
            String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";

            if (statusOfTest == TestStatus.Failed)
            {
                //test.Fail("Test failed", CaptureScreenShot(driver.Value, fileName));
                test.Fail("Test failed", CaptureScreenShot(driver.Value, fileName));
                test.Log(Status.Fail, "test failed with logtrace" + stackTrace);
            }
            else if (statusOfTest == TestStatus.Passed)
            {

            }

            //extent.Flush(); // to fix 
            /*
             TearDown : System.UnauthorizedAccessException : Access to the path 'C:\AutoTest' is denied.
             Stack Trace: 
             --TearDown
             */



            //driver.Value.Close();
            //webDriver.Close();

        }

        //MediaEntityModelProvider -> Media ???
        
        public Media CaptureScreenShot(IWebDriver driver, String screenShotName)
        {
            ITakesScreenshot takeScreenShot = (ITakesScreenshot)driver;
            var screenShot = takeScreenShot.GetScreenshot().AsBase64EncodedString;

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenShot, screenShotName).Build();
        }
        










        // DO NOT REMOVE
        //---------------
        /*     
        <Target Name="CopyCustomontent" AfterTargets="AfterBuild">
		    <Copy SourceFiles="MaybeThisTimeV2.config" DestinationFiles="$(OutDir)\testhost.dll.config"/>
	    </Target>
         */
        //-----------------


    }
}
