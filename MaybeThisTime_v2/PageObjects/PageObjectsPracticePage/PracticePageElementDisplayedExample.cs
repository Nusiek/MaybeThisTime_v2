using MaybeThisTime_v2.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaybeThisTime_v2.PageObjects.PageObjectsPracticePage
{
    internal class PracticePageElementDisplayedExample
    {
        private IWebDriver driver;

        public PracticePageElementDisplayedExample(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        // Displayed Example

        [FindsBy(How = How.Id, Using = "hide-textbox")]
        private IWebElement _ButtonHide;

        [FindsBy(How = How.Id, Using = "show-textbox")]
        private IWebElement _ButtonShow;

        [FindsBy(How = How.Id, Using = "displayed-text")]
        private IWebElement _inputFieldForHideAndShow;


        //--------------------------------------------------------------------------------------------------------------------------------------

        public void HideButtonClick()
        {
            CommonFunctions.ElementClick(_ButtonHide);
        }

        public void ButtonShowClick()
        {
            CommonFunctions.ElementClick(_ButtonShow);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------

        public bool IsElementDisplayed()
        {
            bool isElementDisplayed = CommonFunctions.IsElementDisplayed(_inputFieldForHideAndShow);
            return isElementDisplayed;
        }

        public void SendText(string text)
        {
            CommonFunctions.SendText(_inputFieldForHideAndShow, text);
        }

        public string GetTextFromInput()
        {
            //Thread.Sleep(2000);
            string textFromInput = CommonFunctions.GetText(_inputFieldForHideAndShow);
            //string textFromInput = _inputFieldForHideAndShow.Text;
            //string textFromInput = _inputFieldForHideAndShow.GetAttribute("value")
            //TestContext.Progress.WriteLine("textFromInput: " + textFromInput);
            return textFromInput;
        }

        public string GetPlaceholderValue()
        {
            string placeholderText = CommonFunctions.GetPlaceholderValue(_inputFieldForHideAndShow);
            return placeholderText;
        }

        public bool CompareTwoTexts(string textBefore, string textAfter)
        {
            bool isTextTheSame = CommonFunctions.CompareTwoText(textBefore, textAfter);
            return isTextTheSame;
        }





    }
}
