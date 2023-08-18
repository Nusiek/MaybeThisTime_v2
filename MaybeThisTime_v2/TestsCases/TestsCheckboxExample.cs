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
        [TestCase(TestName = "1. CheckboxExample  - It is checking the first checkbox was checked.",
        Description = "1. CheckboxExample  - It is checking the first checkbox was checked.")]
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
        [TestCase(TestName = "2. CheckboxExample - It is checking if the chosen checkbox is checked.",
        Description = "2. CheckboxExample  - It is checking if the chosen checkbox is checked. " +
        "A number of checkboxes are given by the user..")]
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
        [TestCase(TestName = "3. CheckboxExample  - Counting checked/ unchecked checkboxes.",
        Description = "3. CheckboxExample  - Count how many checkboxes are checked and how many are not checked.")]
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


        [Test, Order(4), Category("CheckboxExample")]
        [TestCase(TestName = "4. CheckboxExample  - It checks all checkboxes and verifies is all are checked.",
        Description = "4. CheckboxExample  - It checks all checkboxes and verifies is all are checked.")]
        public void Test4()
        {
            int numberOfSelectedElements;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageCheckboxExample ppce = new PracticePageCheckboxExample(driver);

            ppce.ChekingAllCheckboxes();

            numberOfSelectedElements = ppce.CountNumbersOfSelestedElement();
            TestContext.Progress.WriteLine("numberOfSelectedElements: " + numberOfSelectedElements);

        }

        [Test, Order(5), Category("CheckboxExample")]
        [TestCase(TestName = "5. CheckboxExample  - It is checking the checkbox by giving a string from UI.",
        Description = "5. CheckboxExample  - It is checking the checkbox by giving a string from UI - what user see.")]
        public void Test5()
        {
            //string checkboxValueUI = "Option"; // it is checked the first element on the list
            string checkboxValueUI = "Option3";
            int numberOfSelectedElements;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageCheckboxExample ppce = new PracticePageCheckboxExample(driver);

            ppce.CheckingCheckboxByGivenStringFromUI(checkboxValueUI);

            numberOfSelectedElements = ppce.CountNumbersOfSelestedElement();
            TestContext.Progress.WriteLine("numberOfSelectedElements: " + numberOfSelectedElements);

        }

    }
}