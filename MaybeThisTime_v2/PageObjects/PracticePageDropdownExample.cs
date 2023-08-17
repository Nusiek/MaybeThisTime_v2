using AngleSharp.Dom;
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
    public class PracticePageDropdownExample
    {
        private IWebDriver driver;

        public PracticePageDropdownExample(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    
        //--------------------------------------------------------------------------------------------------------------------------------------
        // Dropdown Example

        [FindsBy(How = How.Id, Using = "dropdown-class-example")]
        private IWebElement _dropdown;
        private By _dropdownBy = By.Id("dropdown-class-example");

        //

        //--------------------------------------------------------------------------------------------------------------------------------------

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
        // Dropdown Example

        public void DropdownClick()
        {
            IWebElement element = IWebElement(_dropdown);
            CommonFunctions.ElementClick(element);
        }

        /// <summary>
        /// <para> searchText - full name for option in ENG </para>  
        /// </summary>
        /// <param name="searchText"></param>
        public void DropdownSelectOptionByText(string searchText)
        {
            By element = ByElement(_dropdownBy);
            Thread.Sleep(3000);
            DropdownClick(); 
            CommonFunctions.ChooseElementFromList(element, searchText);
            DropdownClick();
        }

        /// <summary>
        /// <para> searchText = index as string for element from the list </para>
        /// </summary>
        /// <param name="searchText"></param>
        public void DropdownSelectOptionBySelectByIndex(string searchText)
        {
            IWebElement element = IWebElement(_dropdown);
            DropdownClick();
            CommonFunctions.ChooseElementFromList(element, 3, searchText);
            DropdownClick();
        }

        /// <summary>
        /// <para> searchText = text for element from the list in UI </para>
        /// </summary>
        /// <param name="searchText"></param>
        public void DropdownSelectOptionBySelectByText(string searchText)
        {
            IWebElement element = IWebElement(_dropdown);
            DropdownClick();
            CommonFunctions.ChooseElementFromList(element, 2, searchText);
            DropdownClick();
        }

        /// <summary>
        /// <para> searchText = value for attribute value </para>
        /// </summary>
        /// <param name="searchText"></param>
        public void DropdownSelectOptionBySelectByValue(string searchText)
        {
            IWebElement element = IWebElement(_dropdown);
            DropdownClick();
            CommonFunctions.ChooseElementFromList(element, 1, searchText);
            DropdownClick();
        }
    }
}
