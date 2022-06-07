using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;


namespace MyShoppingWebsite
{
    [TestFixture]
    public class BaseClass
    {
        public ExtentReports TestResult;
        public IWebDriver driver;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            TestResult = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\LM65883\source\repos\MyTask\youtube\ExtentReport\index.html");
            TestResult.AttachReporter(htmlReporter);
        }
        [SetUp]
        public void SetUpTest()
        {
            String Browser = "Chrome";
            switch (Browser)
            {
                case "Chrome":
                    ExtentTest Reportforchrome = TestResult.CreateTest("BaseClass Start executing the project");
                    driver = new ChromeDriver();
                    Reportforchrome.Log(Status.Info, "Broswer is Lunched");
                    driver.Navigate().GoToUrl(@"https://www.rahulshettyacademy.com/loginpagePractise/");
                    Reportforchrome.Log(Status.Info, "url is opened");
                    driver.Manage().Window.Maximize();
                    Reportforchrome.Log(Status.Info, "Window is maximized");
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
                    Reportforchrome.Log(Status.Info, "Total Setup is ready to execute the test methods");
                    TestResult.Flush();
                    break;
                case "FireFox":
                    ExtentTest TestforFirefox = TestResult.CreateTest("firefox report is started");
                    driver = new FirefoxDriver();
                    TestforFirefox.Log(Status.Info, "Firefox is opened");
                    driver.Navigate().GoToUrl(@"https://www.rahulshettyacademy.com/loginpagePractise/");
                    TestforFirefox.Log(Status.Info, "Url is entered");
                    driver.Manage().Window.Maximize();
                    TestforFirefox.Log(Status.Info, "Window is maximize");
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                    TestResult.Flush();
                    break;
                case "IE":
                    ExtentTest TestforIE = TestResult.CreateTest("IE report is started");
                    driver = new InternetExplorerDriver();
                    TestforIE.Log(Status.Info, "IE is opened");
                    driver.Navigate().GoToUrl(@"https://www.rahulshettyacademy.com/loginpagePractise/");
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                    TestResult.Flush();
                    break;
            }
        }
        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}