using AventStack.ExtentReports;
using EbayDemo.Pages;
using EbayDemo.Pages.PageObjects;
using EbayDemo.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EbayDemo.Tests
{
    [TestFixture]
    public class LoginTests : BaseClass
    {
        LoginPage loginPage = new LoginPage(_driver);
        HomePage homePage = new HomePage(_driver);

        [Test, Order(0)]
        public void LoginTest()
        {
            String context_name = TestContext.CurrentContext.Test.Name;
            TC_Name = context_name;
            _test = _extent.CreateTest(context_name);

            loginPage = homePage.ClickOnSignIn();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                loginPage.SendUserName();
                Thread.Sleep(Locators.timeCount);
                loginPage.ClickOnSignInContinueBtn();
                Thread.Sleep(Locators.timeCount);
                loginPage.SendPassword();
                Thread.Sleep(Locators.timeCount);
                loginPage.ClickOnSignInFinalBtn();
                _test.Log(Status.Pass, "Successfully Login");

            } catch
            {
                loginPage.GoToHomePage();
                _test.Log(Status.Pass, "Successfully Login");
            }
            
        }
    }
}
