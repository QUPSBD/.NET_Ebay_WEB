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
    public class SearchProducts
    {
        private IWebDriver __driver;
        private WebDriverWait wait;

        public SearchProducts(IWebDriver __driver)
        {
            this.__driver = __driver;
            wait = new WebDriverWait(__driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(__driver, this);
        }

        [FindsBy(How = How.XPath, Using = Locators.searchBox)]
        [CacheLookup]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = Locators.searchBtn)]
        [CacheLookup]
        private IWebElement searchBtn;

        [FindsBy(How = How.XPath, Using = Locators.searchPageTextPath)]
        [CacheLookup]
        private IWebElement searchPageTextPath;


        public void ClickOnSearchBox()
        {
            searchBox.Click();
        }

        public void SendSearchItem(String item)
        {
            searchBox.SendKeys(item);
        }

        public void ClickOnSearchBtn()
        {
            bool staleElement = true;

            while (staleElement)
            {
                try
                {
                    searchBtn.Click();

                    staleElement = false;
                }
                catch (StaleElementReferenceException e)
                {
                    staleElement = true;
                }
            }
        }

        public void VerifySearchPage()
        {
            String pageText = searchPageTextPath.Text;

            Assert.AreEqual(pageText, Locators.searchPageText);

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

        [FindsBy(How = How.Id, Using = Locators.categories)]
        [CacheLookup]
        private IWebElement categories;

        [FindsBy(How = How.XPath, Using = Locators.categoryNameHealthAndBeauty)]
        [CacheLookup]
        private IWebElement categoryNameHealthAndBeauty;

        [FindsBy(How = How.XPath, Using = Locators.healthAndBeautyPath)]
        [CacheLookup]
        private IWebElement healthAndBeautyPath;

        public void ClickOnCategoriesBtn()
        {
            categories.Click();
        }

        public void ClickOnItemFromDropBox()
        {
            categoryNameHealthAndBeauty.Click();
        }

        public void VerifyCategorySearchpage()
        {
            String pageText = healthAndBeautyPath.Text;

            Assert.AreEqual(pageText, Locators.healthAndBeautyText);

            Console.WriteLine("Successfully visit " + pageText);
        }
    }
}
