﻿using AngleSharp.Dom;
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
using System.Xml.Linq;

namespace MaybeThisTime_v2.PageObjects
{
    public class PracticePageSuggessionClassExample
    {
        private IWebDriver driver;

        public PracticePageSuggessionClassExample(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        
        //--------------------------------------------------------------------------------------------------------------------------------------
        // Suggession Class

        [FindsBy(How = How.Id, Using = "autocomplete")]
        private IWebElement _inputSuggessioin;

        [FindsBy(How = How.Id, Using = "ui-id-1")]
        private IWebElement _suggestionListUiId;
        private By _suggestionListUiIdBy = By.Id("ui-id-1");
        private By _suggestionListLiByClassName = By.ClassName("ui-menu-item");

     
        private IWebElement IWebElement(IWebElement element)
        {
            IWebElement webElement = element;
            return webElement;
        }

        private By ByElement(By element)
        {
            By byElement = element;
            return byElement;
        }

        
        //--------------------------------------------------------------------------------------------------------------------------------------
        // Sugesstion Class

        public void SugessionClick()
        {
            IWebElement element = IWebElement(_inputSuggessioin);
            CommonFunctions.ElementClick(element);
        }

        public void SugessionTypeText(string text)
        {
            IWebElement element = IWebElement(_inputSuggessioin);
            SugessionClick();
            CommonFunctions.SendText(element, text);
            CommonFunctions.PressArrowDown(element);
        }

        /// <summary>
        /// <para> number -> number count from top to bottom where a country is displayed </para>
        /// <para> if the list contains 3 countries and the search country is displayed as second on the list
        /// as a parameter, we should pass number = 2 </para>
        /// </summary>
        /// <param name="number"></param>
        public void SugessionChooseCountryByClickingArrow(int number)
        {
            IWebElement element = IWebElement(_inputSuggessioin);
            int howManytime = 3;
            CommonFunctions.PressArrowDownMultipleTime(element, howManytime);
        }

        /// <summary>
        /// <para> searchText - full name of country in ENG </para>  
        /// <para> the country is chosen by clicking on its name </para>
        /// </summary>
        /// <param name="searchText"></param>
        public void SugessionChooseCountryByClickingOnTheNameOfCountry(string searchText)
        {
            By element = ByElement(_suggestionListUiIdBy);
            string tagName = "li";
            CommonFunctions.ChooseElementFromList(element, tagName, searchText);
            
        }

        /// <summary>
        /// <para> searchText - full name of country in ENG </para>  
        /// <para> the country is chosen by clicking on its name </para>
        /// </summary>
        /// <param name="searchText"></param>
        public void SugessionChooseCountryByClickingOnTheNameOfCountry2(string searchText)
        {
            Thread.Sleep(4000);
            By element = ByElement(_suggestionListUiIdBy);
            CommonFunctions.ChooseElementFromList(element, searchText);
        }

        
    }
}