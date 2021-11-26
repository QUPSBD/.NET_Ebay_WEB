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
    public class Electronics
    {
        private IWebDriver _driver;
        private WebDriverWait wait;

        public Electronics (IWebDriver _driver)
        {
            this._driver = _driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = Locators.electronicsPath)]
        [CacheLookup]
        private IWebElement verifyElectronicsPage;

        public void VerifyElectronicsPageVisited()
        {
            String pageText = verifyElectronicsPage.Text;

            Assert.AreEqual(pageText, Locators.electronicsText);

            Console.WriteLine("Successfully visit " + pageText);
        }

        [FindsBy(How = How.CssSelector, Using = "#gh-la")]
        [CacheLookup]
        private IWebElement homePageBtn;

        public HomePage GoToHomePage()
        {
            homePageBtn.Click();

            return new HomePage(_driver);
        }
    }
}
