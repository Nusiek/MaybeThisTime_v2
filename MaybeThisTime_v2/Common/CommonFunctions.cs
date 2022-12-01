using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeThisTime_v2.Common
{
    public class CommonFunctions : Base
    {

        public static void ElementClick(IWebElement element)
        {
            element.Click();
        }

        public static void ElementClick(By element)
        {
            IWebElement iWebElement = driver.FindElement(element);
            iWebElement.Click();
        }


        //--------------------------------------------------------------------------------------------------------------------------------------
        // element displayed, enabled, selected
        //--------------------------------------------------------------------------------------------------------------------------------------

        public static bool IsElementDisplayed(IWebElement element)
        {
            bool emementDisplay = element.Displayed;
            return emementDisplay;
        }

        public static bool IsElementEnabled(IWebElement element)
        {
            bool emementEnabled = element.Enabled;
            return emementEnabled;
        }

        public static bool IsElementSelected(IWebElement element)
        {
            bool emementSelected = element.Selected;
            return emementSelected;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        // text
        //--------------------------------------------------------------------------------------------------------------------------------------

        public static string GetText(IWebElement element)
        {
            return element.Text;
        }

        public static int GetTextLenght(string text)
        {
            return text.Length;
        }

        public static void SendText(IWebElement element, string textForInput)
        {
            element.SendKeys(textForInput);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        // random number
        //--------------------------------------------------------------------------------------------------------------------------------------

        public static int GetRandomNumber(int minNumber, int maxNumber)
        {
            Random random = new Random();
            int randomNumber = random.Next(minNumber, maxNumber);
            //TestContext.Progress.WriteLine("randomIndex 3: " + randomNumber);
            return randomNumber;
        }

        public static int ChooseRandomNumberBetweenZeroAndMaxNumber(int maxNumber)
        {
            int minNumber = 0;
            int randomNumber = GetRandomNumber(minNumber, maxNumber);
            //TestContext.Progress.WriteLine("randomIndex 2: " + randomNumber);
            return randomNumber;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        // choose element from list
        //--------------------------------------------------------------------------------------------------------------------------------------

        public static void ChooseElementFromList(IList<IWebElement> elementList, string attributeName, string attributeValue)
        {
            int lenghtList = elementList.Count;

            for (int i = 0; i < lenghtList; i++)
            {
                IWebElement element = elementList[i];

                string elementAttribute = element.GetAttribute($"{attributeName}");
                if (elementAttribute.Equals($"{attributeValue}"))
                {
                    ElementClick(element);
                    break;
                }
            }
        }

        public static void ChooseElementFromListFirstElement(IList<IWebElement> elementList)
        {
            int lenghtList = elementList.Count;

            for (int i = 0; i < lenghtList; i++)
            {
                IWebElement element = elementList[i];

                if (i == 0)
                {
                    ElementClick(element);
                    break;
                }
            }
        }


        public static void ChooseElementFromListLastElement(IList<IWebElement> elementList)
        {
            int lenghtList = elementList.Count - 1;

            for (int i = lenghtList; i >= 0; i--)
            {
                IWebElement element = elementList[i];

                if (i == lenghtList)
                {
                    ElementClick(element);
                    break;
                }
            }
        }

        public static void ChooseElementFromListRandomElement(IList<IWebElement> elementList)
        {
            int lenghtList = elementList.Count;
            int randomIndex = ChooseRandomNumberBetweenZeroAndMaxNumber(lenghtList);

            for (int i = 0; i < lenghtList; i++)
            {
                IWebElement element = elementList[i];

                if (i == randomIndex)
                {
                    ElementClick(element);
                    break;
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        // 
        //--------------------------------------------------------------------------------------------------------------------------------------
    }
}
