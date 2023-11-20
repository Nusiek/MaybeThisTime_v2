using AngleSharp.Dom;
using MaybeThisTime_v2.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RazorEngine.Compilation.ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MaybeThisTime_v2.Common
{
    public class CommonFunctions : Base
    {

        public static void ElementClick(IWebElement element)
        {
            element.Click();
        }

        /*
        public static void ElementClick(By element)
        {
            IWebElement iWebElement = driver.FindElement(element);
            iWebElement.Click();
        }
        */

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
            bool emementSelected = element.Selected; // checked in the box or dot in the radio button
            return emementSelected;
        }

        public static void WaitUntilElementToBeClickable(IWebDriver driver, IWebElement element, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }
            //--------------------------------------------------------------------------------------------------------------------------------------
            // text
            //--------------------------------------------------------------------------------------------------------------------------------------

            public static string GetText(IWebElement element)
        {
            //string text = element.Text;
            string text = element.GetAttribute("value");
            return text;
        }

        public static int GetTextLenght(string text)
        {
            return text.Length;
        }

        public static void SendText(IWebElement element, string textForInput)
        {
            element.SendKeys(textForInput);
        }

        public static string GetPlaceholderValue(IWebElement element)
        {
            string textFromInput = element.GetAttribute("placeholder");
            return textFromInput;
        }

        public static bool CompareTwoText(string text1, string text2)
        {
            bool isTextTheSame = text1.Equals(text2);
            return isTextTheSame;
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

        public static void PressArrowDown(IWebElement elememnt)
        {
            elememnt.SendKeys(Keys.ArrowDown);
        }

        public static void PressEnter(IWebElement elememnt)
        {
            elememnt.SendKeys(Keys.Enter);
        }

        public static void PressBackspace(IWebElement elememnt)
        {
            elememnt.SendKeys(Keys.Backspace);
        }

        public static void PressControlPlusSymbol(IWebElement elememnt, string symbol)
        {
            elememnt.SendKeys(Keys.Control + symbol);
        }

        public static void PressControlPlusA(IWebElement elememnt)
        {
            string symbol = "a";
            PressControlPlusSymbol(elememnt, symbol);
        }

        public static void PressArrowDownMultipleTime(IWebElement elememnt, int honManyTime)
        {
            for (int i = 0; i < honManyTime; i++)
            {
                Thread.Sleep(5000);
                PressArrowDown(elememnt);
            }

            PressEnter(elememnt);
        }

        public IList<IWebElement> CreateElementList(By element)
        {
            IList<IWebElement> elementList = GetDriver().FindElements(element);
            return elementList;
        }

        public IList<IWebElement> CreateElementList(By element, string tagName)
        {
            IList<IWebElement> elementList = GetDriver().FindElement(element).FindElements(By.TagName($"{tagName}"));
            return elementList;
        }

        public int CountListLenght(By element)
        {
            IList<IWebElement> elementList = CreateElementList(element);
            int lenght = elementList.Count();
            return lenght;   
        }

        public int CountListLenght(By element, string tagName)
        {
            IList<IWebElement> elementList = CreateElementList(element, tagName);
            int lenght = elementList.Count();
            TestContext.Progress.WriteLine("lenght: " + lenght);
            return lenght;
        }

        public void ChooseElementFromList(By element, string tagName, string searchText)
        {
            IWebElement elementList;
            IList<IWebElement> elementsList = CreateElementList(element, tagName);
            int lenghtList = CountListLenght (element, tagName);
     
            for (int i = 0; i < lenghtList; i++)
            {
                elementList = elementsList[i];

                string elementListText = elementList.Text;

                if (elementListText.Equals($"{searchText}"))
                {
                    ElementClick(elementList);
                    break;
                }
            }
        }

        public void FindingTagNameByGivenIdNameV1(string idName)
        {
            IWebElement element = driver.Value.FindElement(By.Id($"{idName}"));
            string tagName = element.TagName.ToString();
        }


        public string FindingTagNameByGivenIdName(By element)
        {
            IWebElement webElement = driver.Value.FindElement(element);
            string tagName = webElement.TagName.ToString();
            return tagName;
        } 

        public static string FindingElementListKind(string tagName)
        {
            return tagName switch
            {
                "ul" => "li",
                "ol" => "li",
                "select" => "option",
                _ => "li",
            };
        }

        public void ChooseElementFromList(By element, string searchText)
        {
            IWebElement elementList;
            string tagName = FindingTagNameByGivenIdName(element);
            string tagNameChild = FindingElementListKind(tagName);
            IList<IWebElement> elementsList = CreateElementList(element, tagNameChild);
            int lenghtList = CountListLenght(element, tagNameChild);

            for (int i = 0; i < lenghtList; i++)
            {
                elementList = elementsList[i];
                string elementListText = elementList.Text;

                if (elementListText.Equals($"{searchText}"))
                {
                    ElementClick(elementList);
                    break;
                }
            }
        }

        /// <summary>
        /// <para> int selectedBy = 1 -> element.SelectByValue() </para> 
        /// <para> int selectedBy = 2 -> element.SelectByText() </para> 
        /// <para> int selectedBy = 3 -> element.SelectByIndex() </para> 
        /// <para> ---------------------------------------------- </para> 
        /// <para> string value =  value for attribute value, text, index as string </para> 
        /// </summary>
        /// <param name="iWebElement"></param>
        /// <param name="selectedBy"></param>
        /// <param name="value"></param>
        public static void ChooseElementFromList(IWebElement iWebElement, int selectedBy, string value)
        {
            SelectElement element = new SelectElement(iWebElement);

            if (selectedBy == 1)
            {
                element.SelectByValue($"{value}");
            }

            if (selectedBy == 2)
            {
                element.SelectByText($"{value}");
            }

            if (selectedBy == 3)
            {
                int number = ConvertMethods.ConvertStringToInt(value);
                element.SelectByIndex(number);
            }

        }

        public static string GetWebsiteTitle(IWebDriver driver)
        {
            Thread.Sleep(3000);
            string tabName = driver.Title;
            TestContext.Progress.WriteLine($"tab name: {tabName}");
            return tabName;
        }


        /*
        // too long
        public static Dictionary <int, string> IListDictionary(By element)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            int length = CountListLenght(element);

            for (int i = 1; i <= length; i++)
            {
                //dictionary.Add(i, );
            }


            return dictionary;
        }
        */










        //--------------------------------------------------------------------------------------------------------------------------------------
        // 
        //--------------------------------------------------------------------------------------------------------------------------------------


    }
}
