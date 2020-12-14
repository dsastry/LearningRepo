using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.LearningProject.BaseClass;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports.Reporter;

namespace NUnit.LearningProject
{
    [TestFixture]
    public class TestClass2 : TestBase
    {
       
       
     
        [Test]
        public void TestMethod()
        {

            test = extent.CreateTest("First Test Method").Info("Test Starting") ;
            driver.Manage().Window.Maximize();
            test.Log(Status.Info, "Chrome browser is launched");
            IWebElement linktext = driver.FindElement(By.Id("email"));
            linktext.SendKeys("hello");
            test.Log(Status.Pass, "Email Id has been entered and test has passed");


        }

        [Test]
        public void TestMethod_2()
        {

            driver.Manage().Window.Maximize();

            IWebElement createNewAccnt = driver.FindElement(By.Id("u_0_2"));
            createNewAccnt.Click();

            System.Threading.Thread.Sleep(2000);

            // To handle all new opened window.				

            // Switching to Child window


            IWebElement popupCheck = driver.FindElement(By.Id("reg_box"));

            driver.SwitchTo().Frame(popupCheck);

            IWebElement monthElement = driver.FindElement(By.XPath(".//*[@id='month']"));

            SelectElement selectMonth = new SelectElement(monthElement);

            selectMonth.SelectByIndex(11);




        }
    }
}
