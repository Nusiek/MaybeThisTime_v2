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
    internal class PracticePageCheckboxExample
    {
        private IWebDriver driver;

        public PracticePageCheckboxExample(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        // Checkbox Example

        [FindsBy(How = How.Id, Using = "checkBoxOption1")]
        private IWebElement _checkBoxOption1;

        [FindsBy(How = How.Id, Using = "checkBoxOption2")]
        private IWebElement _checkBoxOption2;

        [FindsBy(How = How.Id, Using = "checkBoxOption3")]
        private IWebElement _checkBoxOption3;
        
        [FindsBy(How = How.Id, Using = "checkbox-example")]
        private IWebElement _allCheckboxesParent;
        

        private IWebElement IWebElement(IWebElement element)
        {
            IWebElement webElement = element;
            return webElement;
        }

        public void ChooseOption(IWebElement element)
        {
            CommonFunctions.ElementClick(element);
        }

        public void ChooseOptionOne()
        {
            IWebElement element = IWebElement(_checkBoxOption1);
            CommonFunctions.ElementClick(element);
        }

        public void ChooseOptionThree()
        {
            IWebElement element = IWebElement(_checkBoxOption3);
            CommonFunctions.ElementClick(element);
        }

        public bool IsElementChecked()
        {
            IWebElement element = IWebElement(_checkBoxOption1);
            bool isElementSelected = CommonFunctions.IsElementSelected(element);
            return isElementSelected;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------
        // test xD

        public static List<bool> ListOfElementsWithBoolResults(IWebElement _allCheckboxesParent)
        {
            List<bool> listWithResults = new List<bool>();
            List<IWebElement> _allCheckboxElement = new List<IWebElement>();

            //List<IWebElement> _allCheckboxElement = _allCheckboxesParent.FindElement(By.CssSelector("input[type='checkbox']"));
            //IWebElement element = _allCheckboxesParent.FindElements(By.CssSelector("input[type='checkbox']"))[0];

            int numberOfElement = _allCheckboxesParent.FindElements(By.CssSelector("input[type='checkbox']")).Count;

            for (int i = 0; i < numberOfElement; i++)
            {
                IWebElement element = _allCheckboxesParent.FindElements(By.CssSelector("input[type='checkbox']"))[i];
                bool isElementChecked = CommonFunctions.IsElementSelected(element);
                listWithResults.Add(isElementChecked);
            }

            return listWithResults;

        }

        /// <summary>
        /// number start from 0
        /// </summary>
        /// <param name="numberOfCheckboxToVerify"></param>
        /// <returns></returns>
        public bool isElementSelected(int numberOfCheckboxToVerify)
        {
            bool isGivenCheckboxSelected;
            List<bool> listWithResults = ListOfElementsWithBoolResults(_allCheckboxesParent);

            isGivenCheckboxSelected = listWithResults[numberOfCheckboxToVerify];

            return isGivenCheckboxSelected;
        }

        public int CountNumbersOfSelestedElement()
        {
            List<bool> listWithResults = ListOfElementsWithBoolResults(_allCheckboxesParent);
            bool isElementSelected;
            int numberOfSelectedElements = 0;         
            int elementsNumber = listWithResults.Count;

            for (int i = 0; i < elementsNumber; i++)
            {
                isElementSelected = listWithResults[i];

                if(isElementSelected == true)
                {
                    numberOfSelectedElements = numberOfSelectedElements + 1;
                }
            }

            return numberOfSelectedElements;
        }

        public int CountNumbersOfNotSelestedElement()
        {
            List<bool> listWithResults = ListOfElementsWithBoolResults(_allCheckboxesParent);
            bool isElementSelected;
            int numberOfSelectedElements = 0;
            int elementsNumber = listWithResults.Count;

            for (int i = 0; i < elementsNumber; i++)
            {
                isElementSelected = listWithResults[i];

                if (isElementSelected == false)
                {
                    numberOfSelectedElements = numberOfSelectedElements + 1;
                }
            }

            return numberOfSelectedElements;
        }

    }
}
