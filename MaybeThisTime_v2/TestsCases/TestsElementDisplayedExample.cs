using MaybeThisTime_v2.PageObjects;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeThisTime_v2.TestsCases
{
    internal class TestsElementDisplayedExample : Base
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test, Order(1), Category("ElementDisplayedExample")]
        [TestCase(TestName = "1. ElementDisplayedExample  - checking if the element is displayed at the beginning.",
        Description = "1. ElementDisplayedExample  - checking if the element is displayed at the beginning.")]
        public void Test1()
        {
            bool isDisplayed;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageElementDisplayedExample ppede = new PracticePageElementDisplayedExample(driver);

            ppede.HideButtonClick();
            isDisplayed = ppede.IsElementDisplayed();

            TestContext.Progress.WriteLine("isDisplayed: " + isDisplayed);
        }


        [Test, Order(2), Category("ElementDisplayedExample")]
        [TestCase(TestName = "2. ElementDisplayedExample  - checking if the element is not displayed.",
        Description = "2. ElementDisplayedExample  - checking if the element is not displayed after clicking on the button to hide.")]
        public void Test2()
        {
            bool isDisplayed;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageElementDisplayedExample ppede = new PracticePageElementDisplayedExample(driver);

            ppede.HideButtonClick();
            isDisplayed = ppede.IsElementDisplayed();

            TestContext.Progress.WriteLine("isDisplayed: " + isDisplayed);
        }


        [Test, Order(3), Category("ElementDisplayedExample")]
        [TestCase(TestName = "3. ElementDisplayedExample  - checking if element is displayed after cliking on the button show.",
        Description = "3. ElementDisplayedExample  - checking if the element is not displayed after clicking on the button to hide and show")]
        public void Test3()
        {
            bool isDisplayed;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageElementDisplayedExample ppede = new PracticePageElementDisplayedExample(driver);

            ppede.HideButtonClick();
            ppede.ButtonShowClick();
            isDisplayed = ppede.IsElementDisplayed();

            TestContext.Progress.WriteLine("isDisplayed: " + isDisplayed);
        }

        [Test, Order(4), Category("ElementDisplayedExample")]
        [TestCase(TestName = "4. ElementDisplayedExample  - checking the text in the input before and after the field is displayed",
        Description = "4. ElementDisplayedExample  - checking the text in the input before clicking on the button hide and after clicking on the button show the field is displayed.")]
        public void Test4()
        {
            bool isTextTheSame;
            string text = "example of text xD";
            string textBefore;
            string textAfter;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageElementDisplayedExample ppede = new PracticePageElementDisplayedExample(driver);

            ppede.SendText(text);
            textBefore = ppede.GetTextFromInput();
            ppede.HideButtonClick();
            ppede.ButtonShowClick();
            textAfter = ppede.GetTextFromInput();

            isTextTheSame = ppede.CompareTwoTexts(textBefore, textAfter);

            TestContext.Progress.WriteLine("textBefore: " + textBefore);
            TestContext.Progress.WriteLine("textAfter: " + textAfter);
            TestContext.Progress.WriteLine("isTextTheSame: " + isTextTheSame);
        }

        [Test, Order(5), Category("ElementDisplayedExample")]
        [TestCase(TestName = "5. ElementDisplayedExample  - checking the value of the placeholder before hiding the input.",
        Description = "5. ElementDisplayedExample  - checking the value of the placeholder before hiding the input by clicking on the button hide.")]
        public void Test5()
        {
            bool isTextTheSame;
            string valueOfPlaceholderBefore = "Hide / Show Example";
            string valueOfPlaceholderAfter;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageElementDisplayedExample ppede = new PracticePageElementDisplayedExample(driver);

            ppede.HideButtonClick();
            ppede.ButtonShowClick();
            valueOfPlaceholderAfter = ppede.GetPlaceholderValue();

            isTextTheSame = ppede.CompareTwoTexts(valueOfPlaceholderBefore, valueOfPlaceholderAfter);

            TestContext.Progress.WriteLine("valueOfPlaceholderAfter: " + valueOfPlaceholderAfter);
        }

    }
}
