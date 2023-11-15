using MaybeThisTime_v2.Common;
using MaybeThisTime_v2.PageObjects.PageObjectsPracticePage;
using MaybeThisTime_v2.utilities;
using NUnit.Framework;
using System;
using System.Threading;

namespace MaybeThisTime_v2.TestsCases.TestsCasesPracticePage
{
    public class TestsSwitchTabExample : Base
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test, Order(1), Category("SwitchTabExample")]
        [TestCase(TestName = "1. SwitchTabExample  - ",
            Description = "1. SwitchTabExample  - ")]

        public void Test1()
        {
            string parcialTextForInput = "Pol";
            string textFromInput;

            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PracticePageSwitchTabExample ppste = new PracticePageSwitchTabExample(driver.Value);

            ppste.ClickButtonOpenTab();
            ppste.ClickButtonOpenTab();
            ppste.ClickButtonOpenTab();
            ppste.ClickButtonOpenTab();
            Thread.Sleep(5000);
            //ppste.SwitchTab();


        }




    }
}