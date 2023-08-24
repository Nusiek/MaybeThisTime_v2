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
    public class PracticePage
    {
        private IWebDriver driver;

        public PracticePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        // page objects
        //--------------------------------------------------------------------------------------------------------------------------------------
        // Radio Button 

        [FindsBy(How = How.Id, Using = "radio-btn-example")]
        private IWebElement _radioBtnExample;

        [FindsBy(How = How.XPath, Using = "//div[@id='radio-btn-example']/fieldset/label/input[@type='radio']")]
        private IList<IWebElement> _radioInputsList;

        [FindsBy(How = How.XPath, Using = "//div[@id='radio-btn-example']/fieldset/label/input[@value='radio1']")]
        private IWebElement _buttonRadio1;

        [FindsBy(How = How.XPath, Using = "//div[@id='radio-btn-example']/fieldset/label/input[@value='radio2']")]
        private IWebElement _buttonRadio2;

        [FindsBy(How = How.XPath, Using = "//div[@id='radio-btn-example']/fieldset/label/input[@value='radio3']")]
        private IWebElement _buttonRadio3;

        //--------------------------------------------------------------------------------------------------------------------------------------
        // Suggession Class

        [FindsBy(How = How.Id, Using = "autocomplete")]
        private IWebElement _inputSuggessioin;

        [FindsBy(How = How.Id, Using = "ui-id-1")]
        private IWebElement _suggestionListUiId;
        private By _suggestionListUiIdBy = By.Id("ui-id-1");
        private By _suggestionListLiByClassName = By.ClassName("ui-menu-item");

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
        // page dictionary
        //--------------------------------------------------------------------------------------------------------------------------------------
        // Radio Button 

        /// <summary>
        /// <para> DictionaryRadioButtonValue dictionaryId: </para>
        /// <para> 1 = radio1 </para>
        /// <para> 2 = radio2 </para>
        /// <para> 3 = radio3 </para>
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <returns></returns>
        private string DictionaryRadioButtonValue(int dictionaryId)
        {
            string radio1 = "radio1";
            string radio2 = "radio2";
            string radio3 = "radio3";

            Dictionary<int, string> DictionaryValue = new Dictionary<int, string>()
            {
                {1, radio1},
                {2, radio2},
                {3, radio3}
            };

            string choosenDictionaryValue = DictionaryValue[dictionaryId];
            return choosenDictionaryValue;

        }

        /// <summary>
        /// <para> DictionaryIWebElementRadioButton dictionaryId: </para>
        /// <para> 1 = radio1 </para>
        /// <para> 2 = radio2 </para>
        /// <para> 3 = radio3 </para>
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <returns></returns>
        private IWebElement DictionaryIWebElementRadioButton(int dictionaryId)
        {
            IWebElement buttonRadio10 = IWebElement(_buttonRadio1);
            IWebElement buttonRadio20 = IWebElement(_buttonRadio2);
            IWebElement buttonRadio30 = IWebElement(_buttonRadio3);

            Dictionary<int, IWebElement> DictionaryIWebElement = new Dictionary<int, IWebElement>()
            {
                { 1, buttonRadio10},
                { 2, buttonRadio20},
                { 3, buttonRadio30}
            };

            IWebElement elementFromDictionary = DictionaryIWebElement[dictionaryId];
            return elementFromDictionary;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        // page action
        //--------------------------------------------------------------------------------------------------------------------------------------
        // Radio Button 

        /// <summary>
        /// <para> DictionaryRadioButtonValue dictionaryId: </para>
        /// <para> 1 = radio1 </para>
        /// <para> 2 = radio2 </para>
        /// <para> 3 = radio3 </para>
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <returns></returns>
        public void ChooseElementFromListTypeRadioByAttributeValue(int dictionaryId)
        {
            IList<IWebElement> typeRadioList = _radioInputsList;
            string attributeValue = DictionaryRadioButtonValue(dictionaryId);
            string attributeName = "Value";
            CommonFunctions.ChooseElementFromList(typeRadioList, attributeName, attributeValue);
        }

        public void ChooseElementFromListTypeRadioFirstElement()
        {
            IList<IWebElement> typeRadioList = _radioInputsList;
            CommonFunctions.ChooseElementFromListFirstElement(typeRadioList);
        }

        public void ChooseElementFromListTypeRadioLastElement()
        {
            IList<IWebElement> typeRadioList = _radioInputsList;
            CommonFunctions.ChooseElementFromListLastElement(typeRadioList);
        }


        public void ChooseElementFromListTypeRadioRandomElement()
        {
            IList<IWebElement> typeRadioList = _radioInputsList;
            CommonFunctions.ChooseElementFromListRandomElement(typeRadioList);
        }


        /// <summary>
        /// <para> DictionaryIWebElementRadioButton dictionaryId: </para>
        /// <para> 1 = radio1 </para>
        /// <para> 2 = radio2 </para>
        /// <para> 3 = radio3 </para>
        /// </summary>
        /// <param name="dictionaryId"></param>
        /// <returns></returns>
        /// 
        public bool IsElementSelectedRadioButton(int dictionaryId)
        {
            IWebElement element = DictionaryIWebElementRadioButton(dictionaryId);
            bool IsElementSelected = CommonFunctions.IsElementSelected(element);
            return IsElementSelected;
        }



        public void ChooseElementFromList2(string attributeName, string attributeValue)
        {
            IList<IWebElement> elementsList = new List<IWebElement>();
            elementsList = _radioInputsList;
            //TestContext.Progress.WriteLine("elementsList: " + elementsList);
            //TestContext.Progress.WriteLine("------------------ " );

            int lenghtList = elementsList.Count;
            TestContext.Progress.WriteLine("lenghtList: " + lenghtList);

            for (int i = 0; i < lenghtList; i++)
            {
                IWebElement element = elementsList[i];

                string elementAttribute = element.GetAttribute($"{attributeName}");
                if (elementAttribute.Equals($"{attributeValue}"))
                {
                    //IWebElement element = elementsList[i];
                    CommonFunctions.ElementClick(element);
                    break;
                }

            }

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

        public string GetText()
        {
            string text = CommonFunctions.GetText(_inputSuggessioin);
            return text;
        }


    }
}
