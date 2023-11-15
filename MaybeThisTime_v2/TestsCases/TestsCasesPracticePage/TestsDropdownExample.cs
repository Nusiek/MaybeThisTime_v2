using MaybeThisTime_v2.PageObjects.PageObjectsPracticePage;
using MaybeThisTime_v2.utilities;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeThisTime_v2.TestsCases.TestsCasesPracticePage
{
    public class TestsDropdownExample : Base
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test, Order(1), Category("DropdownExample")]
        [TestCase(TestName = "1. DropdownExample  - id for select.",
            Description = "1. DropdownExample  - choosing option for the list by giving the id for select.")]
        public void Test1()
        {
            string expectedText = "Option1";
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageDropdownExample ppde = new PracticePageDropdownExample(driver.Value);
            ppde.DropdownSelectOptionByText(expectedText);

        }

        /*
        [Test, Order(2), Category("DropdownExample")]
        [TestCase(TestName = "2. DropdownExample  - SelectElement + SelectByIndex().",
            Description = "2. DropdownExample  - choosing an option for the list using SelectByIndex().")]
        public void Test2()
        {
            string expectedText = "2";
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageDropdownExample ppde = new PracticePageDropdownExample(driver.Value);
            ppde.DropdownSelectOptionBySelectByIndex(expectedText);

        }


        [Test, Order(3), Category("DropdownExample")]
        [TestCase(TestName = "3. DropdownExample  - SelectElement + SelectByText().",
            Description = "3. DropdownExample  - choosing an option for the list using SelectByText().")]
        public void Test3()
        {
            string expectedText = "Option3";
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageDropdownExample ppde = new PracticePageDropdownExample(driver.Value);
            ppde.DropdownSelectOptionBySelectByText(expectedText);

        }


        [Test, Order(4), Category("DropdownExample")]
        [TestCase(TestName = "4. DropdownExample  - SelectElement + SelectByValue().",
            Description = "4. DropdownExample  - choosing an option for the list using SelectByValue().")]
        public void Test4()
        {
            string expectedText = "option2";
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageDropdownExample ppde = new PracticePageDropdownExample(driver.Value);
            ppde.DropdownSelectOptionBySelectByValue(expectedText);

        }
        */
    }
}
