using EbayDemo.Pages.PageObjects;
using EbayDemo.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayDemo.Pages.HomePageElements.PageObjects
{
    public class Motors
    {
        private IWebDriver __driver;
        private WebDriverWait wait;

        public Motors(IWebDriver __driver)
        {
            this.__driver = __driver;
            wait = new WebDriverWait(__driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(__driver, this);
        }

        public void VerifyMotorsPage()
        {

            Assert.AreEqual(__driver.Url, Locators.motorsPageUrl);

            Console.WriteLine("Successfully visit " + Locators.motorsPageUrl);
        }

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
