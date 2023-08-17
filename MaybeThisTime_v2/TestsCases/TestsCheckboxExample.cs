using MaybeThisTime_v2.Common;
using MaybeThisTime_v2.PageObjects;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace MaybeThisTime_v2.TestsCases
{
    public class TestsCheckboxExample : Base
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test, Order(1), Category("CheckboxExample")]
        [TestCase(TestName = "1. CheckboxExample  - arrow",
            Description = "1. CheckboxExample  - choosing a country from the list by clicking the arrow.")]
        public void Test1()
        {
            bool isCheckedExpected = true;
            bool isChecked;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageCheckboxExample ppce = new PracticePageCheckboxExample(driver);

            ppce.ChooseOptionOne();
            isChecked = ppce.IsElementChecked();

            TestContext.Progress.WriteLine("isChecked: " + isChecked);
        }


        [Test, Order(2), Category("CheckboxExample")]
        [TestCase(TestName = "2. CheckboxExample  - ",
                Description = "2. CheckboxExample  - .")]
        public void Test2()
        {
            bool isCheckedExpected = true;
            bool isCheckedFirstCheckbox;
            bool isCheckedSecondCheckbox;
            bool isCheckedThirdCheckbox;

            int firstCheckboxToVerify = 0;
            int secondCheckboxToVerify = 1;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageCheckboxExample ppce = new PracticePageCheckboxExample(driver);

            ppce.ChooseOptionOne();
            ppce.ChooseOptionThree();

            isCheckedFirstCheckbox = ppce.isElementSelected(firstCheckboxToVerify);
            isCheckedSecondCheckbox = ppce.isElementSelected(secondCheckboxToVerify);
            isCheckedThirdCheckbox = ppce.isElementSelected(secondCheckboxToVerify);

            TestContext.Progress.WriteLine("isCheckedFirstCheckbox: " + isCheckedFirstCheckbox);
            TestContext.Progress.WriteLine("isCheckedSecondCheckbox: " + isCheckedSecondCheckbox);
            TestContext.Progress.WriteLine("thirdCheckboxToVerify: " + isCheckedThirdCheckbox);

        }


        [Test, Order(3), Category("CheckboxExample")]
        [TestCase(TestName = "3. CheckboxExample  - ",
        Description = "3. CheckboxExample  - .")]
        public void Test3()
        {
            bool isCheckedExpected = true;
            int numberOfSelectedElements;
            int numberOfNotSelectedElements;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageCheckboxExample ppce = new PracticePageCheckboxExample(driver);

            ppce.ChooseOptionOne();

            numberOfSelectedElements = ppce.CountNumbersOfSelestedElement();
            numberOfNotSelectedElements = ppce.CountNumbersOfNotSelestedElement();

            TestContext.Progress.WriteLine("numberOfSelectedElements: " + numberOfSelectedElements);
            TestContext.Progress.WriteLine("numberOfNotSelectedElements: " + numberOfNotSelectedElements);

        }
    }
}