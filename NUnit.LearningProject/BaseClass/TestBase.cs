using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.LearningProject.BaseClass
{
    [TestFixture]
    public class TestBase
    {
        public IWebDriver driver;
        public ExtentReports extent = null;
        public ExtentTest test = null;

        [OneTimeSetUp]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.facebook.com/";

            

            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\DeepakMahabalaSastry\source\repos\NUnit.LearningProject\NUnit.LearningProject\extent.html");
            extent.AttachReporter(htmlReporter);


        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            driver.Quit();   
        }

    }
}
