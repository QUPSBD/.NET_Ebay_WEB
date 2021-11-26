using AventStack.ExtentReports;
using EbayDemo.Pages;
using EbayDemo.Pages.HomePageElements;
using EbayDemo.Pages.HomePageElements.PageObjects;
using EbayDemo.Pages.PageObjects;
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
    public class HomeElementsTests : BaseClass
    {
        HomePage homePage = new HomePage(_driver);
        DailyDeals dailyDeals = new DailyDeals(_driver);


        [Test, Order(2)]
        public void HomePageElementsTest()
        {
            String context_name = TestContext.CurrentContext.Test.Name;
            TC_Name = context_name;
            _test = _extent.CreateTest(context_name);

            //this do login
            /* LoginPage loginPage = homePage.ClickOnSignIn();
             __driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
             loginPage.SendUserName();
             loginPage.ClickOnSignInContinueBtn();
             Thread.Sleep(2000);
             loginPage.SendPassword();
             Thread.Sleep(2000);
             loginPage.ClickOnSignInFinalBtn();
             Thread.Sleep(2000);

             //this will verify dailydeals
             homePage = loginPage.GoToHomePage();*/

            Thread.Sleep(Locators.timeCount);
            dailyDeals = homePage.ClickOnDailyDealsBtn();
            Thread.Sleep(Locators.timeCount);
            dailyDeals.VerifyDealsPageVisited();
            _test.Log(Status.Pass, "Successfully visited Daily Deals Page from Menu Bar");
            Thread.Sleep(Locators.timeCount);

            //this will verify helpAndContact
            HelpAndContact helpAndContact = dailyDeals.ClickOnHelpAndContactBtn();
            Thread.Sleep(Locators.timeCount);
            helpAndContact.VerifyHelpAndContactPageVisited();
            _test.Log(Status.Pass, "Successfully visited Help And Contact Page from Menu Bar");
            Thread.Sleep(Locators.timeCount);

            //this will verify Selling page
            Selling selling = helpAndContact.ClickOnSellBtn();
            //selling.VerifySellingPathVisited();
            _test.Log(Status.Pass, "Successfully visited Selling Page from Menu Bar");
            Thread.Sleep(Locators.timeCount);
            homePage = selling.GoToHomePage();

            Thread.Sleep(Locators.timeCount);
            //this will verify watchlist
            homePage.ClickOnWatchListBtn();
            //homePage.VerifyNoWatchList();
            _test.Log(Status.Pass, "Successfully Check WatchList from Menu Bar");

            //this will verify electronics page
            Thread.Sleep(Locators.timeCount);
            homePage.ClickOnWatchListBtn();
            Electronics electronics = homePage.ClickOnElectronicsBtn();
            electronics.VerifyElectronicsPageVisited();
            _test.Log(Status.Pass, "Successfully Visited Electronics Page from Menu Bar");
            Thread.Sleep(Locators.timeCount);
            homePage = electronics.GoToHomePage();
            Thread.Sleep(Locators.timeCount);

            //this will verify fashion page
            Fashion fashion = homePage.ClickOnFashionBtn();
            Thread.Sleep(Locators.timeCount);
            fashion.VerifyFashionPageVisited();
            _test.Log(Status.Pass, "Successfully Visited Fashion Page from Menu Bar");
            homePage = fashion.GoToHomePage();
            Thread.Sleep(Locators.timeCount);

            //this will verify health & beauty page
            HealthAndBeauty healthAndBeauty = homePage.ClickOnHealthAndBeautyBtn();
            Thread.Sleep(Locators.timeCount);
            healthAndBeauty.VerifyHealthAndBeautyPage();
            _test.Log(Status.Pass, "Successfully Visited Health And Beauty Page from Menu Bar");
            homePage = healthAndBeauty.GoToHomePage();
            Thread.Sleep(Locators.timeCount);

            //this will verify sports page
            Sports sports = homePage.ClickOnSportsBtn();
            Thread.Sleep(Locators.timeCount);
            sports.VerifySportsPage();
            _test.Log(Status.Pass, "Successfully Visited Sports Page from Menu Bar");
            homePage = sports.GoToHomePage();
            Thread.Sleep(Locators.timeCount);

            //this will verify Collectibles and art page
            CollectiblesAndArt collectiblesAndArt = homePage.ClickOnCollectiblesAndArtBtn();
            Thread.Sleep(Locators.timeCount);
            collectiblesAndArt.VerifyCollectiblesAndArtPage();
            _test.Log(Status.Pass, "Successfully Visited Collectibles And Art Page from Menu Bar");
            homePage = collectiblesAndArt.GoToHomePage();
            Thread.Sleep(Locators.timeCount);

            //this will verify Industrial equipment page
            IndustrialEquipment industrialEquipment = homePage.ClickOnIndustrialEquipmentBtn();
            Thread.Sleep(Locators.timeCount);
            industrialEquipment.VerifyIndustrialEquipmentPage();
            _test.Log(Status.Pass, "Successfully Visited Industrial Equipment Page from Menu Bar");
            homePage = industrialEquipment.GoToHomePage();
            Thread.Sleep(Locators.timeCount);

            //this will verify Motors page
            Motors motors = homePage.ClickOnMotorsBtn();
            Thread.Sleep(Locators.timeCount);
            motors.VerifyMotorsPage();
            _test.Log(Status.Pass, "Successfully Visited Motors Page from Menu Bar");
            homePage = motors.GoToHomePage();
            Thread.Sleep(Locators.timeCount);
        }
    }
}
