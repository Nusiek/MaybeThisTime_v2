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

namespace MaybeThisTime_v2.PageObjects.PageObjectsPracticePage
{
    public class PracticePageRadioBattonExample
    {
        private IWebDriver driver;

        public PracticePageRadioBattonExample(IWebDriver driver)
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

        [FindsBy(How = How.Id, Using = "radio-btn-example")]
        private IWebElement _allRadioButtonParent;

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


    }
}
