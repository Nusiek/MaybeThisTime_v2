using MaybeThisTime_v2.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaybeThisTime_v2.PageObjects.PageObjectsProtoCommerceMainPage
{
    internal class PageObjectsProtoCommerceMainPage
    {
        private IWebDriver _driver;

        public PageObjectsProtoCommerceMainPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        // OBJECTS -> start



        // OBJECTS <- end
        //--------------------------------------------------------------------------------------------------------------------------------------

        // ACTIONS  tab name -> start

        public string GetWebsiteTitle()
        {
            string webpageTitle = CommonFunctions.GetWebsiteTitle(_driver);
            return webpageTitle;
        }

        // ACTIONS  tab name <- end
        //--------------------------------------------------------------------------------------------------------------------------------------

    }
}
