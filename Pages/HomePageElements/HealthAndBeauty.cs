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
    public class HealthAndBeauty
    {
        private IWebDriver __driver;
        private WebDriverWait wait;

        public HealthAndBeauty(IWebDriver __driver)
        {
            this.__driver = __driver;
            wait = new WebDriverWait(__driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(__driver, this);
        }

        [FindsBy(How = How.XPath, Using = Locators.healthAndBeautyPath)]
        [CacheLookup]
        private IWebElement healthAndBeautyPath;

        public void VerifyHealthAndBeautyPage()
        {
            String pageText = healthAndBeautyPath.Text;

            Assert.AreEqual(pageText, Locators.healthAndBeautyText);

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
