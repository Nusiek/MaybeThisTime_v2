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
            string expectedText = "Pol";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);

            pp.SugessionTypeText(expectedText);
            pp.SugessionChooseCountryByClickingArrow(3);

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
        [TestCase(TestName = "3. SuggessionClassExample - id for ul + li).",
                Description = "3. SuggessionClassExample - finding country by giving id for ul and tag li.")]
        public void Test3()
        {
            string expectedText = "Poland";
            string parcialTextForInput = "pol";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);

            pp.SugessionTypeText(parcialTextForInput);
            //Thread.Sleep(4000);
            pp.SugessionChooseCountryByClickingOnTheNameOfCountry(expectedText);

        }

        [Test, Order(4), Category("SuggessionClassExample")]
        [TestCase(TestName = "4. SuggessionClassExample - id for ul.",
            Description = "4. SuggessionClassExample - finding country by giving id for ul.")]
        public void Test4()
        {
            string expectedText = "Poland";
            string parcialTextForInput = "pol";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);

            pp.SugessionTypeText(parcialTextForInput);
            pp.SugessionChooseCountryByClickingOnTheNameOfCountry2(expectedText);

        }


    }
}