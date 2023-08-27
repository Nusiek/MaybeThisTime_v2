using MaybeThisTime_v2.Common;
using MaybeThisTime_v2.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;

namespace MaybeThisTime_v2.TestsCases
{
    public class TestsSuggessionClassExample : Base
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test, Order(1), Category("SuggessionClassExample")]
        [TestCase(TestName = "1. SuggessionClassExample  - arrow",
            Description = "1. SuggessionClassExample  - choosing a country from the list by clicking the arrow.")]
        public void Test1()
        {
            string parcialTextForInput = "Pol";
            string expectedText = "Poland";
            string textFromInput;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);

            pp.SugessionTypeText(parcialTextForInput);
            pp.SugessionChooseCountryByClickingArrow(3);

            textFromInput = pp.GetText();
            TestContext.Progress.WriteLine("textFromInput: " + textFromInput);

        }

      /* to do
        [Test, Order(2), Category("SuggessionClassExample")]
        [TestCase(TestName = "2. SuggessionClassExample - class for li.",
            Description = "2. SuggessionClassExample - finding country by giving class for li.")]
        public void Test2()
        {
            string expectedText = "Poland";
            string parcialTextForInput = "pol";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);

            pp.SugessionTypeText(parcialTextForInput);
            //Thread.Sleep(4000);
            pp.SugessionChooseCountryByClickingOnTheNameOfCountry2(expectedText);

        }
        */
        
        [Test, Order(3), Category("SuggessionClassExample")]
        [TestCase(TestName = "3. SuggessionClassExample - ).",
                Description = "3. SuggessionClassExample - choosing a country by clicking on the name of the country.")]
        public void Test3()
        {
            string expectedText = "Poland";
            string parcialTextForInput = "pol";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);

            pp.SugessionTypeText(parcialTextForInput);
            pp.SugessionChooseCountryByClickingOnTheNameOfCountry(expectedText);

        }

        [Test, Order(4), Category("SuggessionClassExample")]
        [TestCase(TestName = "4. SuggessionClassExample - ",
            Description = "4. SuggessionClassExample - choosing a country by clicking on the name of the country version 2.")]
        public void Test4()
        {
            string expectedText = "Poland";
            string parcialTextForInput = "pol";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);

            pp.SugessionTypeText(parcialTextForInput);
            pp.SugessionChooseCountryByClickingOnTheNameOfCountry2(expectedText);

        }


        [Test, Order(5), Category("SuggessionClassExample")]
        [TestCase(TestName = "5. SuggessionClassExample - .",
            Description = "5. SuggessionClassExample - counting displayed elements on the list.")]
        public void Test5()
        {
            //string expectedText = "Poland";
            string parcialTextForInput = "po";
            int countElements;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageSuggessionClassExample ppsce = new PracticePageSuggessionClassExample(driver);

            //ppsce.SugessionTypeText(parcialTextForInput);
            countElements = ppsce.CountElementsOnTheList(parcialTextForInput);

            TestContext.Progress.WriteLine("countElements: " + countElements);

        }


    }
}