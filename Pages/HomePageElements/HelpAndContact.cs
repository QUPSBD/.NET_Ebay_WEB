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
    public class HelpAndContact
    {
        private IWebDriver _driver;
        private WebDriverWait wait;

        public HelpAndContact(IWebDriver _driver)
        {
            this._driver = _driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = Locators.customerServiceId)]
        [CacheLookup]
        private IWebElement helpAndContactPage;

        [FindsBy(How = How.LinkText, Using = Locators.sell)]
        [CacheLookup]
        private IWebElement sellBtn;

        public Selling ClickOnSellBtn()
        {
            sellBtn.Click();

            return new Selling(_driver);
        }

        public void VerifyHelpAndContactPageVisited()
        {
            String pageText = helpAndContactPage.Text;

            Assert.AreEqual(pageText, Locators.customerServicesText);

            Console.WriteLine("Successfully visit " + pageText);
        }
    }
}
