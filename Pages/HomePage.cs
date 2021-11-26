using EbayDemo.Pages.HomePageElements;
using EbayDemo.Pages.HomePageElements.PageObjects;
using EbayDemo.Pages.PopularCategories.PageObjects;
using EbayDemo.Tests;
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

namespace EbayDemo.Pages.PageObjects
{
    public class HomePage
    {
        String homePageUrl = Locators.homePageUrl;

        private IWebDriver __driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver __driver)
        {
            this.__driver = __driver;
            wait = new WebDriverWait(__driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(__driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Watchlist")]
        [CacheLookup]
        private IWebElement watchListBtn;

        [FindsBy(How = How.XPath, Using = "//div[@id='gh-wl-click-flyout']")]
        [CacheLookup]
        private IWebElement watchListVerifyText;

        [FindsBy(How = How.LinkText, Using = "Sign in")]
        [CacheLookup]
        private IWebElement signInBtn;

        [FindsBy(How = How.LinkText, Using = Locators.electronics)]
        [CacheLookup]
        private IWebElement electronicsBtn;

        public void GoToPage() => __driver.Navigate().GoToUrl(homePageUrl);

        public LoginPage ClickOnSignIn() { 
            signInBtn.Click();

            return new LoginPage(__driver);
        }

        [FindsBy(How = How.LinkText, Using = Locators.dailyDeals)]
        [CacheLookup]
        private IWebElement dailyDealsBtn;

        public DailyDeals ClickOnDailyDealsBtn()
        {
            dailyDealsBtn.Click();

            return new DailyDeals(__driver);
        }

        public void ClickOnWatchListBtn() => watchListBtn.Click();

        public void VerifyNoWatchList()
        {
            String pageText = watchListVerifyText.Text;

            Assert.AreEqual(pageText, "Looks like you are not watching any items yet.");

            Console.WriteLine("Successfully visit " + pageText);
        }

        public Electronics ClickOnElectronicsBtn()
        {
            electronicsBtn.Click();

            return new Electronics(__driver);
        }

        [FindsBy(How = How.LinkText, Using = Locators.fashion)]
        [CacheLookup]
        private IWebElement fashionBtn;

        public Fashion ClickOnFashionBtn()
        {
            fashionBtn.Click();

            return new Fashion(__driver);
        }

        [FindsBy(How = How.LinkText, Using = Locators.healthAndBeauty)]
        [CacheLookup]
        private IWebElement healthAndBeautyBtn;

        public HealthAndBeauty ClickOnHealthAndBeautyBtn()
        {
            healthAndBeautyBtn.Click();

            return new HealthAndBeauty(__driver);
        }

        [FindsBy(How = How.LinkText, Using = Locators.sports)]
        [CacheLookup]
        private IWebElement sportsBtn;
        
        public Sports ClickOnSportsBtn()
        {
            sportsBtn.Click();

            return new Sports(__driver);
        }

        [FindsBy(How = How.LinkText, Using = Locators.collectiblesAndArtPage)]
        [CacheLookup]
        private IWebElement collectiblesAndArtPageBtn;

        public CollectiblesAndArt ClickOnCollectiblesAndArtBtn()
        {
            collectiblesAndArtPageBtn.Click();

            return new CollectiblesAndArt(__driver);
        }

        [FindsBy(How = How.XPath, Using = Locators.industrialEquipmentPage)]
        [CacheLookup]
        private IWebElement industrialEquipmentPageBtn;

        public IndustrialEquipment ClickOnIndustrialEquipmentBtn()
        {
            industrialEquipmentPageBtn.Click();

            return new IndustrialEquipment(__driver);
        }

        [FindsBy(How = How.LinkText, Using = Locators.motorsPage)]
        [CacheLookup]
        private IWebElement motorsPageBtn;

        public Motors ClickOnMotorsBtn()
        {
            motorsPageBtn.Click();

            return new Motors(__driver);
        }

        [FindsBy(How = How.XPath, Using = Locators.sneakers)]
        [CacheLookup]
        private IWebElement sneakersBtn;

        public Sneakers CliickOnSneakersBtn()
        {
            CommonMethods commonMethods = new CommonMethods(__driver);

            commonMethods.ScrollToElement(sneakersBtn);
            Thread.Sleep(Locators.timeCount);
            sneakersBtn.Click();

            return new Sneakers(__driver);
        }

        [FindsBy(How = How.XPath, Using = Locators.koreanBeauty)]
        [CacheLookup]
        private IWebElement koreanBeautyBtn;

        public KoreanBeauty ClickOnKoreanBeauty()
        {
            CommonMethods commonMethods = new CommonMethods(__driver);

            commonMethods.ScrollToElement(koreanBeautyBtn);
            Thread.Sleep(Locators.timeCount);
            koreanBeautyBtn.Click();

            return new KoreanBeauty(__driver);
        }

        [FindsBy(How = How.XPath, Using = Locators.wristWatches)]
        [CacheLookup]
        private IWebElement wristWatchesBtn;

        public WristWatches ClickOnWristWatches()
        {
            CommonMethods commonMethods = new CommonMethods(__driver);

            commonMethods.ScrollToElement(wristWatchesBtn);
            Thread.Sleep(Locators.timeCount);
            wristWatchesBtn.Click();

            return new WristWatches(__driver);
        }

        [FindsBy(How = How.XPath, Using = Locators.fishing)]
        [CacheLookup]
        private IWebElement fishingBtn;
        public Fishing ClickOnFishing()
        {
            CommonMethods commonMethods = new CommonMethods(__driver);

            commonMethods.ScrollToElement(fishingBtn);
            Thread.Sleep(Locators.timeCount);
            fishingBtn.Click();

            return new Fishing(__driver);
        }

        [FindsBy(How = How.XPath, Using = Locators.collectibles)]
        [CacheLookup]
        private IWebElement collectiblesBtn;
        public Collectibles ClickOnCollectibles()
        {
            CommonMethods commonMethods = new CommonMethods(__driver);

            commonMethods.ScrollToElement(collectiblesBtn);
            Thread.Sleep(Locators.timeCount);
            collectiblesBtn.Click();

            return new Collectibles(__driver);
        }

        [FindsBy(How = How.XPath, Using = Locators.smartPhones)]
        [CacheLookup]

        private IWebElement smartPhonesBtn;
        internal SmartPhones ClickOnSmartPhones()
        {
            CommonMethods commonMethods = new CommonMethods(__driver);

            commonMethods.ScrollToElement(smartPhonesBtn);
            Thread.Sleep(Locators.timeCount);
            smartPhonesBtn.Click();

            return new SmartPhones(__driver);
        }

        [FindsBy(How = How.XPath, Using = Locators.popularSell)]
        [CacheLookup]
        private IWebElement popularSellBtn;

        public PopularSell ClickOnPopularSell()
        {
            CommonMethods commonMethods = new CommonMethods(__driver);

            commonMethods.ScrollToElement(popularSellBtn);
            Thread.Sleep(Locators.timeCount);
            popularSellBtn.Click();

            return new PopularSell(__driver);
        }
    }
}
