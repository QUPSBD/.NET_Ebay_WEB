using System;
using System.Collections.Generic;
using System.Text;

namespace EbayDemo.Utils
{
    class Locators
    {
        public static int timeCount = 2000;
        public static String homePageUrl = "https://www.ebay.com/";
        public static String fbLoginPageTitle = "Log in to Facebook | Facebook";

        //homePageTests
        public const String deals = "Deals";
        public const String customerServiceId = "gh-title";
        public const String dealsText = "Deals";
        public const String customerServicesText = "Customer Service";
        public const String sellingPath = "/html/body/div[2]/div[1]/div/div[1]/h1";
        public const String sellText = "You are on selling home page\nSelling";
        public const String electronicsPath = "/html/body/div[5]/div[2]/h1/span";
        public const String electronicsText = "Electronics";
        public const String fashionPath = "/html/body/div[5]/div[2]/nav/ol/li[2]/span";
        public const String fashionText = "Fashion That’s Made for You";
        public const String healthAndBeautyPath = "/html/body/div[5]/div[2]/h1/span";
        public const String healthAndBeautyText = "Health & Beauty";
        public const String homeAndGardenPath = "Home & Garden";
        public const String homeAndGardenText = "Home & Garden";
        public const String sportsPath = "/html/body/div[5]/div[2]/section/div[1]/div[2]/h1";
        public const String sportsText = "Sporting Goods";
        public const String collectiblesAndArtPagePath = "/html/body/div[5]/div[2]/nav/ol/li[2]/span";
        public const String collectiblesAndArtPageText = "Collectibles";
        public const String industrialEquipmentPagePath = "/html/body/div[5]/div[2]/h1/span";
        public const String industrialEquipmentPageText = "Business & Industrial";
        public const String motorsPageUrl = "https://www.ebay.com/sch/6028/i.html?_from=R40&_nkw=Auto+Parts+Accessories&_blrs=recall_filtering";

        public const String dailyDeals = "Daily Deals";
        public const String helpAndContact = "Help & Contact";
        public const String sell = "Sell";
        public const String electronics = "Electronics";
        public const String fashion = "Fashion";
        public const String healthAndBeauty = "Health & Beauty";
        public const String homeAndGarden = "Home & Garden";
        public const String sports = "Sports";
        public const String collectiblesAndArtPage = "Collectibles and Art";
        public const String industrialEquipmentPage = "//*[@id='mainContent']/div[1]/ul/li[9]/a";
        public const String motorsPage = "Motors";

        //popular categories
        public const String sneakers = "//*[@id='destinations_list1']/ul/li[1]";
        public const String koreanBeauty = "//*[@id='destinations_list1']/ul/li[2]";
        public const String wristWatches = "//*[@id='destinations_list1']/ul/li[3]";
        public const String fishing = "//*[@id='destinations_list1']/ul/li[4]";
        public const String collectibles = "//*[@id='destinations_list1']/ul/li[5]";
        public const String smartPhones = "//*[@id='destinations_list1']/ul/li[6]";
        public const String popularSell = "//*[@id='destinations_list1']/ul/li[7]";

        public const String sneakersUrl = "https://www.ebay.com/b/Retail-Campaign/bn_7116433159";
        public const String koreanBeautyUrl = "https://www.ebay.com/b/Korean-Health-and-Beauty/bn_7116437158";
        public const String wristWatchesUrl = "https://www.ebay.com/b/Wristwatches/31387/bn_2408451";
        public const String fishingUrl = "https://www.ebay.com/b/Fishing-Equipment-Supplies/1492/bn_1851047";
        public const String collectiblesUrl = "https://www.ebay.com/b/Collectibles-Art/bn_7000259855";
        public const String smartPhonesUrl = "https://www.ebay.com/b/Cell-Phones-Smart-Watches-Accessories/15032/bn_1865441";
        public const String popularSellUrl = "https://export.ebay.com/ru/";

        //Sell
        public const String startSellingPageUrl = "https://www.ebay.com/sl/sell";
        public const String learnToSellPageUrl = "https://pages.ebay.com/seller-center/get-started/selling-basics.html";
        public const String affiliatesPageUrl = "https://partnernetwork.ebay.com/";

        //Search Product

        public const String searchBox = "//*[@id='gh-ac']";
        public const String searchBtn = "//*[@id='gh-btn']";
        public const String searchPageTextPath = "//*[@id='mainContent']/div[1]/div/div[2]/div[1]/div[1]/h1/span[2]";
        public const String searchPageText = "mobile";
        public const String categories = "gh-cat";
        public const String categoryNameHealthAndBeauty = "//*[@id='gh-cat']/option[20]";

        //Sign In
        public const String signIn = "Sign in";
    }
}
