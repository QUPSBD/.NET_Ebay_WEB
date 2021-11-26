using EbayDemo.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayDemo.Pages.PageObjects
{
    public class Selling
    {
        private IWebDriver _driver;
        private WebDriverWait wait;

        public Selling(IWebDriver _driver)
        {
            this._driver = _driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.LinkText, Using = Locators.sellingPath)]
        [CacheLookup]
        private IWebElement sellingPathBtn;

        public void VerifySellingPathVisited()
        {
            String pageText = sellingPathBtn.Text;

            Assert.AreEqual(pageText, Locators.sellText);

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
