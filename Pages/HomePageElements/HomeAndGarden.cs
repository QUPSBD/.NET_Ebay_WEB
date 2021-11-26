using EbayDemo.Pages.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayDemo.Pages.HomePageElements.PageObjects
{
    public class HomeAndGarden
    {
        private IWebDriver __driver;
        private WebDriverWait wait;

        public HomeAndGarden(IWebDriver __driver)
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
    }
}
