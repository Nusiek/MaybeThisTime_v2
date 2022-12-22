using MaybeThisTime_v2.Common;
using MaybeThisTime_v2.PageObjects;
using NUnit.Framework;
using System;

namespace MaybeThisTime_v2.TestsCases
{
    public class TestsRadioButtonExample : Base
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, Order(1), Category("RadioButtonExample")]
        [TestCase(TestName = "1. RadioButtonExample  - attribute value",
            Description = "1. RadioButtonExample  - choose element from the list by attribute value.")]
        public void Test1()
        {
            bool isElementSelected = true;
            bool isOtherElementsSelected = false;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);

            pp.ChooseElementFromListTypeRadioByAttributeValue(2);
            bool webIsElementSelectedRadio1 = pp.IsElementSelectedRadioButton(1);
            bool webIsElementSelectedRadio2 = pp.IsElementSelectedRadioButton(2);
            bool webIsElementSelectedRadio3 = pp.IsElementSelectedRadioButton(3);
        }
        

        [Test, Order(2), Category("RadioButtonExample")]
        [TestCase(TestName = "2. RadioButtonExample  - choose the first element", 
            Description = "2. RadioButtonExample  - choose the first element from the list.")]
        public void Test2()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);
            pp.ChooseElementFromListTypeRadioFirstElement();
        }


        [Test, Order(3), Category("RadioButtonExample")]
        [TestCase(TestName = "3. RadioButtonExample  - choose the last element",
            Description = "3. RadioButtonExample  - choose the last element from the list.")]
        public void Test3()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);
            pp.ChooseElementFromListTypeRadioLastElement();
        }


        [Test, Order(4), Category("RadioButtonExample")]
        [TestCase(TestName = "4. RadioButtonExample  - choose a random element",
            Description = "4. RadioButtonExample  - choose a random element from the list.")]
        public void Test4()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);
            pp.ChooseElementFromListTypeRadioRandomElement();
        }

    }
}