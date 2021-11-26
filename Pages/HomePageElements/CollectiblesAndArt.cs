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
    public class CollectiblesAndArt
    {
        private IWebDriver __driver;
        private WebDriverWait wait;

        public CollectiblesAndArt(IWebDriver __driver)
        {
            this.__driver = __driver;
            wait = new WebDriverWait(__driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(__driver, this);
        }

        [FindsBy(How = How.XPath, Using = Locators.collectiblesAndArtPagePath)]
        [CacheLookup]
        private IWebElement collectiblesAndArtPagePath;

        public void VerifyCollectiblesAndArtPage()
        {
            String pageText = collectiblesAndArtPagePath.Text;

            Assert.AreEqual(pageText, Locators.collectiblesAndArtPageText);

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
