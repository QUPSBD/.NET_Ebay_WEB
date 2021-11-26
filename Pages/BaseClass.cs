using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using EbayDemo.Pages.PageObjects;
using EbayDemo.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace EbayDemo.Pages
{
    public class BaseClass
    {
        public static IWebDriver _driver = new ChromeDriver();

        public ExtentReports _extent;
        public ExtentTest _test;
        public String TC_Name;

        [OneTimeSetUp]
        public void StartReport()
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            Directory.CreateDirectory(projectPath.ToString() + "Reports");

            string reportPath = projectPath + "Reports\\MyOwnReport.html";

            var htmlReporter = new ExtentHtmlReporter(reportPath);
            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);
            _extent.AddSystemInfo("Host Name", "Asif Rouf");
            _extent.AddSystemInfo("Environment", "QA");
            _extent.AddSystemInfo("UserName", "Syed Ashiq");
            htmlReporter.LoadConfig(projectPath + "extent-config.xml");
        }
        
        [SetUp]
        public void setUp()
        {
            _driver.Navigate().GoToUrl(Locators.homePageUrl);
            _driver.Manage().Window.Maximize();
            Thread.Sleep(Locators.timeCount);
        }

        [OneTimeTearDown]
        protected void ExtentClose()
        {
            Console.WriteLine("OneTimeTearDown");
            _extent.Flush();
            
        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(Locators.timeCount);
            bool passed = TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Passed;
            var exec_status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace) ? ""
            : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus = Status.Pass;
            String screenShotPath, fileName;

            DateTime time = DateTime.Now;
            fileName = "Screenshot_" + time.ToString("h_mm_ss") + TC_Name + ".png";

            switch (exec_status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    /* The older way of capturing screenshots */
                    screenShotPath = Capture(_driver, fileName);
                    /* Capturing Screenshots using built-in methods in ExtentReports 4 */
                    var mediaEntity = CaptureScreenShot(_driver, fileName);
                    _test.Log(Status.Fail, "Fail");
                    /* Usage of MediaEntityBuilder for capturing screenshots */
                    _test.Fail("ExtentReport 4 Capture: Test Failed", mediaEntity);
                    /* Usage of traditional approach for capturing screenshots */
                    _test.Log(Status.Fail, "Traditional Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                    break;
                case TestStatus.Passed:
                    logstatus = Status.Pass;
                    /* The older way of capturing screenshots */
                    screenShotPath = Capture(_driver, fileName);
                    /* Capturing Screenshots using built-in methods in ExtentReports 4 */
                    mediaEntity = CaptureScreenShot(_driver, fileName);
                    _test.Log(Status.Pass, "Pass");
                    /* Usage of MediaEntityBuilder for capturing screenshots */
                    _test.Pass("ExtentReport 4 Capture: Test Passed", mediaEntity);
                    /* Usage of traditional approach for capturing screenshots */
                    _test.Log(Status.Pass, "Traditional Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    break;
            }
            _test.Log(logstatus, "Test: " + TC_Name + " Status:" + logstatus + stacktrace);

            //_driver.Close();
            
        }

        public static string Capture(IWebDriver driver, String screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            var pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            var reportPath = new Uri(actualPath).LocalPath;
            Directory.CreateDirectory(reportPath + "Reports\\" + "Screenshots");
            var finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "Reports\\Screenshots\\" + screenShotName;
            var localpath = new Uri(finalpth).LocalPath;
            screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
            return reportPath;
        }

        public MediaEntityModelProvider CaptureScreenShot(IWebDriver driver, String screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            var screenshot = ts.GetScreenshot().AsBase64EncodedString;

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenShotName).Build();
        }
    }
}
