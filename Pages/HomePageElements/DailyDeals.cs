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
    public class DailyDeals
    {
        private IWebDriver __driver;
        private WebDriverWait wait;

        public DailyDeals(IWebDriver __driver)
        {
            this.__driver = __driver;
            wait = new WebDriverWait(__driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(__driver, this);
        }

        [FindsBy(How = How.LinkText, Using = Locators.deals)]
        [CacheLookup]
        private IWebElement verifyDealsPage;

        [FindsBy(How = How.LinkText, Using = Locators.helpAndContact)]
        [CacheLookup]
        private IWebElement helpAndContactBtn;

        public HelpAndContact ClickOnHelpAndContactBtn()
        {
            helpAndContactBtn.Click();

            return new HelpAndContact(__driver);
        }

        public void VerifyDealsPageVisited()
        {
            String pageText = verifyDealsPage.Text;

            Assert.AreEqual(pageText, Locators.dealsText);

            Console.WriteLine("Successfully visit " + pageText);
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
