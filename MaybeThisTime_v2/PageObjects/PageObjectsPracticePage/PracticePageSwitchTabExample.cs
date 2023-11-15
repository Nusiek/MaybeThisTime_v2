using AngleSharp.Dom;
using MaybeThisTime_v2.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MaybeThisTime_v2.PageObjects.PageObjectsPracticePage
{
    public class PracticePageSwitchTabExample
    {
        private IWebDriver driver;

        public PracticePageSwitchTabExample(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        //--------------------------------------------------------------------------------------------------------------------------------------
        // SwitchTabExample

        [FindsBy(How = How.Id, Using = "opentab")]
        private IWebElement _buttonOpenTab;


        public void ClickButtonOpenTab()
        {
            CommonFunctions.ElementClick(_buttonOpenTab);
        }

        public void SwitchTab()
        {
            //driver.SwitchTo().NewWindow(WindowType.Window);
            //driver.SwitchTo().NewWindow(WindowType.Tab);
            //driver.SwitchTo().Window(driver.WindowHandles[0]);

            //driver.SwitchTo().Window(driver.WindowHandles[1]);
            //driver.SwitchTo().Window(driver.WindowHandles[2]);


            //string windowHandle = this.driver.WindowHandles.Last(); // using System.Linq
            //string windowHandle = this.driver.WindowHandles.First(); // using System.Linq
            //this.driver.SwitchTo().Window(windowHandle);

            string windowHandle2 = driver.WindowHandles.Last(); // using System.Linq
            driver.SwitchTo().Window(windowHandle2);

        }




    }
}
