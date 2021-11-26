using AventStack.ExtentReports;
using EbayDemo.Pages;
using EbayDemo.Pages.PageObjects;
using EbayDemo.Pages.PopularCategories.PageObjects;
using EbayDemo.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EbayDemo.Tests
{
    [TestFixture]
    public class PopularCategories : BaseClass
    {
        HomePage homePage = new HomePage(_driver);

        [Test, Order(3)]
        public void PopularCategoriesTest()
        {
            String context_name = TestContext.CurrentContext.Test.Name;
            TC_Name = context_name;
            _test = _extent.CreateTest(context_name);

            //verify sneakers
            Sneakers sneakers = homePage.CliickOnSneakersBtn();
            Thread.Sleep(Locators.timeCount);
            sneakers.VerifySneakersPage();
            _test.Log(Status.Pass, "Visited Sneakers Category Page");
            homePage = sneakers.GoToHomePage();
            Thread.Sleep(Locators.timeCount);

            //verify korean beauty page
            KoreanBeauty koreanBeauty = homePage.ClickOnKoreanBeauty();
            Thread.Sleep(Locators.timeCount);
            koreanBeauty.VerifyKoreanBeautyPage();
            _test.Log(Status.Pass, "Visited KoreanBeauty Category Page");
            homePage = koreanBeauty.GoToHomePage();
            Thread.Sleep(Locators.timeCount);

            //verify wrist watches page
            WristWatches wristWatches = homePage.ClickOnWristWatches();
            Thread.Sleep(Locators.timeCount);
            wristWatches.VerifyWristWatchesPage();
            _test.Log(Status.Pass, "Visited Wrist Watches Category Page");
            homePage = wristWatches.GoToHomePage();
            Thread.Sleep(Locators.timeCount);

            //verify Fishing page
            Fishing fishing = homePage.ClickOnFishing();
            Thread.Sleep(Locators.timeCount);
            fishing.VerifyFishingPage();
            _test.Log(Status.Pass, "Visited Fishing Category Page");
            homePage = fishing.GoToHomePage();
            Thread.Sleep(Locators.timeCount);

            //verify collectibles page
            Collectibles collectibles = homePage.ClickOnCollectibles();
            Thread.Sleep(Locators.timeCount);
            collectibles.VerifyCollectiblesPage();
            _test.Log(Status.Pass, "Visited Collectibles Category Page");
            homePage = collectibles.GoToHomePage();
            Thread.Sleep(Locators.timeCount);

            //verify smartphones page
            SmartPhones smartPhones = homePage.ClickOnSmartPhones();
            Thread.Sleep(Locators.timeCount);
            smartPhones.VerifySmartPhonesPage();
            _test.Log(Status.Pass, "Visited Smart Phones Category Page");
            homePage = smartPhones.GoToHomePage();

            //verify popular sell page
            PopularSell popularSell = homePage.ClickOnPopularSell();
            Thread.Sleep(Locators.timeCount);
            popularSell.VerifyPopularSellPage();
            _test.Log(Status.Pass, "Visited Popular Sell Category Page");
            //homePage = popularSell.GoToHomePage();
            Thread.Sleep(Locators.timeCount);
        }
    }
}
