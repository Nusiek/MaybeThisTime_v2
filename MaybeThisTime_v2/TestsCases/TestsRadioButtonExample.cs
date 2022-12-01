using MaybeThisTime_v2.Common;
using MaybeThisTime_v2.PageObjects;
using NUnit.Framework;
using System;

namespace MaybeThisTime_v2.TestsCases
{
    public class Tests : Base
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, Order(1), Category("RadioButtonExample")]
        [TestCase(TestName = "1. RadioButtonExample",
            Description = "")]
        public void Test1()
        {
            //string attributeValue = "radio1";
            bool isElementSelected = true;
            bool isOtherElementsSelected = false;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);

            pp.ChooseElementFromListTypeRadioByAttributeValue(1);
            bool webIsElementSelectedRadio1 = pp.IsElementSelectedRadioButton(1);
            bool webIsElementSelectedRadio2 = pp.IsElementSelectedRadioButton(2);
            bool webIsElementSelectedRadio3 = pp.IsElementSelectedRadioButton(3);


        }

        [Test, Order(2), Category("RadioButtonExample")]
        [TestCase(TestName = "2. RadioButtonExample",
            Description = "")]
        public void Test2()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);

            pp.ChooseElementFromListTypeRadioFirstElement();
        }

        [Test, Order(3), Category("RadioButtonExample")]
        [TestCase(TestName = "3. RadioButtonExample",
            Description = "")]
        public void Test3()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);

            pp.ChooseElementFromListTypeRadioLastElement();
        }


        [Test, Order(4), Category("RadioButtonExample")]
        [TestCase(TestName = "4. RadioButtonExample",
            Description = "")]
        public void Test4()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePage pp = new PracticePage(driver);

            pp.ChooseElementFromListTypeRadioRandomElement();
        }

    }
}