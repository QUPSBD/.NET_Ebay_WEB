using EbayDemo.Pages.PageObjects;
using EbayDemo.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace EbayDemo.Pages.PageObjects
{
    public class Fashion
    {
        private IWebDriver __driver;
        private WebDriverWait wait;

        public Fashion(IWebDriver __driver)
        {
            this.__driver = __driver;
            wait = new WebDriverWait(__driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(__driver, this);
        }

        [FindsBy(How = How.XPath, Using = Locators.fashionPath)]
        [CacheLookup]
        private IWebElement fashionPath;

        public void VerifyFashionPageVisited()
        {
            String pageText = fashionPath.Text;

            Assert.AreEqual(pageText, Locators.fashionText);

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