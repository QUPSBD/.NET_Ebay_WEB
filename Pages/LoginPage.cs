using EbayDemo.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayDemo.Pages.PageObjects
{
    public class LoginPage
    {
        String homePageUrl = Locators.homePageUrl;

        private IWebDriver __driver;
        private WebDriverWait wait;

        public LoginPage(IWebDriver __driver)
        {
            this.__driver = __driver;
            wait = new WebDriverWait(__driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(__driver, this);
        }

        

        [FindsBy(How = How.Id, Using = "userid")]
        [CacheLookup]
        private IWebElement userName;

        [FindsBy(How = How.Id, Using = "signin-continue-btn")]
        [CacheLookup]
        private IWebElement signInContinueBtn;

        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "sgnBt")]
        [CacheLookup]
        private IWebElement signInFinalBtn;

       
        public void SendUserName() => userName.SendKeys("ashiq.qups@gmail.com");

        public void ClickOnSignInContinueBtn() => signInContinueBtn.Click();

        public void SendPassword() => password.SendKeys("123456789As@");

        public void ClickOnSignInFinalBtn() => signInFinalBtn.Click();


        [FindsBy(How = How.CssSelector, Using = "#gh-la")]
        [CacheLookup]
        private IWebElement homePageBtn;

        public HomePage GoToHomePage()
        {
            homePageBtn.Click();

            return new HomePage(__driver);
        }

    }
}
