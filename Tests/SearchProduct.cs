using AventStack.ExtentReports;
using EbayDemo.Pages;
using EbayDemo.Pages.PageObjects;
using EbayDemo.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EbayDemo.Tests
{
    [TestFixture]
    public class SearchProduct : BaseClass
    {
        HomePage homePage = new HomePage(_driver);
        SearchProducts searchProduct = new SearchProducts(_driver);

        [Test,Order(1)]
        public void searchItemFromSearchBox()
        {
            String context_name = TestContext.CurrentContext.Test.Name;
            TC_Name = context_name;
            _test = _extent.CreateTest(context_name);

            Thread.Sleep(Locators.timeCount);
            searchProduct.ClickOnSearchBox();
            Thread.Sleep(Locators.timeCount);
            searchProduct.SendSearchItem("Mobile");
            Thread.Sleep(Locators.timeCount);
            searchProduct.ClickOnSearchBtn();
            Thread.Sleep(Locators.timeCount);
            searchProduct.VerifySearchPage();
            _test.Log(Status.Pass, "Successfully Search Item From Search Box");
            Thread.Sleep(Locators.timeCount);
            searchProduct.GoToHomePage();
        }

        [Test, Order(4)]
        public void searchItemFromCategory()
        {
            String context_name = TestContext.CurrentContext.Test.Name;
            TC_Name = context_name;
            _test = _extent.CreateTest(context_name);

            Thread.Sleep(Locators.timeCount);
            searchProduct.ClickOnCategoriesBtn();
            Thread.Sleep(Locators.timeCount);
            searchProduct.ClickOnItemFromDropBox();
            Thread.Sleep(Locators.timeCount);
            searchProduct.ClickOnSearchBtn();
            Thread.Sleep(Locators.timeCount);
            searchProduct.VerifyCategorySearchpage();
            _test.Log(Status.Pass, "Successfully Search Item From Category list");
            Thread.Sleep(Locators.timeCount);
            searchProduct.GoToHomePage();
            Thread.Sleep(Locators.timeCount);
        }
    }
}
