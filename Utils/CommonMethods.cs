using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EbayDemo.Utils.PageObjects
{
    public class CommonMethods
    {
        private IWebDriver __driver;
        private WebDriverWait wait;

        public CommonMethods(IWebDriver __driver)
        {
            this.__driver = __driver;
            wait = new WebDriverWait(__driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(__driver, this);
        }

        public void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)__driver;
            //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);

            /*Actions actions = new Actions(__driver);
            actions.MoveToElement(element);
            actions.Perform();*/
        }

        public void ScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)__driver;
            Thread.Sleep(Locators.timeCount);
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            
        }

        public void ScrollUp()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)__driver;
            Thread.Sleep(Locators.timeCount);
            js.ExecuteScript("window.scrollTo(0, 0)");
        }
    }
}
