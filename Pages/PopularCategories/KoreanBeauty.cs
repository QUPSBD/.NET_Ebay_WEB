using EbayDemo.Pages.PageObjects;
using EbayDemo.Utils;
using EbayDemo.Utils.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EbayDemo.Pages.PopularCategories.PageObjects
{
    public class KoreanBeauty
    {
        private IWebDriver __driver;
        private WebDriverWait wait;

        public KoreanBeauty(IWebDriver __driver)
        {
            this.__driver = __driver;
            wait = new WebDriverWait(__driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(__driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#gh-la")]
        [CacheLookup]
        private IWebElement homePageBtn;

        public HomePage GoToHomePage()
        {
            homePageBtn.Click();

            return new HomePage(__driver);
        }

        public void VerifyKoreanBeautyPage()
        {
            CommonMethods commonMethods = new CommonMethods(__driver);

            commonMethods.ScrollDown();
            commonMethods.ScrollUp();
            Thread.Sleep(Locators.timeCount);

            Assert.AreEqual(__driver.Url, Locators.koreanBeautyUrl);
            Console.WriteLine("Successfully visit " + Locators.koreanBeautyUrl);
        }
    }
}
