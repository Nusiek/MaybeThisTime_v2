using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaybeThisTime_v2.PageObjects;
using MaybeThisTime_v2.PageObjects.PageObjectsPracticeLoginPage;
using MaybeThisTime_v2.utilities;
using NUnit.Framework;

namespace MaybeThisTime_v2.TestsCases.TestsCasesPracticeLoginPage
{
    public class TestsCasesPracticeLoginPage : Base
    {

        [Test, Order(1), Category("TestsLoginPage")]
        [TestCase(TestName = "z",
            Description = "z")]

        public void Test1()
        {

            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(driver.Value);
            poplp.SendCorrectUsername();
            poplp.SendCorrectPassword();
            poplp.ClickRadioButtonUser();


        }



    }
}
