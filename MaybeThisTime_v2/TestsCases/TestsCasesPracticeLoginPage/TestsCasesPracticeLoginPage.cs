using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaybeThisTime_v2.PageObjects;
using MaybeThisTime_v2.PageObjects.PageObjectsPracticeLoginPage;
using MaybeThisTime_v2.PageObjects.PageObjectsProtoCommerceMainPage;
using MaybeThisTime_v2.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MaybeThisTime_v2.TestsCases.TestsCasesPracticeLoginPage
{
    public class TestsCasesPracticeLoginPage : Base
    {
        //public IWebDriver driver2 = GetDriver();
        //--- Tests - log in to the account -> start
        [Test, Order(1), Category("TestsAllLoginPage"), Category("TestsLogInToAccount")]
        [TestCase(TestName = "1. Correct login and password.",
            Description = "It checks log in to the account by providing the correct login and password. " +
                          "It checks if the user succeeds in logging in.")]

        public void Test1()
        {
            //driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            //PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(driver.Value);
            //PageObjectsProtoCommerceMainPage popcmp = new PageObjectsProtoCommerceMainPage(driver.Value);
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());
            PageObjectsProtoCommerceMainPage popcmp = new PageObjectsProtoCommerceMainPage(GetDriver());

            string expectedWebsiteName = poplp.GetWebsiteTitleNameFromDictiorayAfterLogIn();
           
            poplp.SendCorrectUsername();
            poplp.SendCorrectPassword();
            poplp.ClicksOnSinInButtons();

            string actualWebsiteName = popcmp.GetWebsiteTitle();
        }


        [Test, Order(2), Category("TestsAllLoginPage"), Category("TestsLogInToAccount")]
        [TestCase(TestName = "2. Incorrect login and password.",
            Description = "It checks log in to the account by providing the incorrect login and password. " +
                          "It checks if a notification about the wrong login and password is displayed. " +
                          "It checks if the correct text notification about the wrong login and password is displayed. " +
                          "It checks if the user succeeds in logging in.")]
        public void Test2()
        {
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());

            string expectedWebsiteName = poplp.GetWebsiteTitleNameFromDictioray();
            bool expectedIsNotificationForIncorrectDataForLogInDisplayed = true;
            string expectedWebsiteNotification = poplp.GetnotificationIncorrectLoginPassword();
            
            poplp.SendIncorrectUsername();
            poplp.SendIncorrectPassword();
            poplp.ClicksOnSinInButtons();

            string actualWebsiteName = poplp.GetWebsiteTitle();
            bool isActualNotificationForIncorrectDataForLogInDisplayed = poplp.IsNotificationForIncorrectDataForLogInDisplayed();
            string actualWebsiteNotification = poplp.GetNotificationForIncorrectDataForLogIn();      
        }


        [Test, Order(3), Category("TestsAllLoginPage"), Category("TestsLogInToAccount")]
        [TestCase(TestName = "3. Correct login and incorrect password.",
            Description = "It checks log in to the account by providing the correct login and incorrect password. " +
                          "It checks if a notification about the wrong login and password is displayed. " +
                          "It checks if the correct text notification about the wrong login and password is displayed.")]
        public void Test3()
        {
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(driver.Value);

            string expectedWebsiteName = poplp.GetWebsiteTitleNameFromDictioray();
            bool expectedIsNotificationForIncorrectDataForLogInDisplayed = true;
            string expectedWebsiteNotification = poplp.GetnotificationIncorrectLoginPassword();

            poplp.SendCorrectUsername();
            poplp.SendIncorrectPassword();
            poplp.ClicksOnSinInButtons();

            string actualWebsiteName = poplp.GetWebsiteTitle();
            bool isActualNotificationForIncorrectDataForLogInDisplayed = poplp.IsNotificationForIncorrectDataForLogInDisplayed();
            string actualWebsiteNotification = poplp.GetNotificationForIncorrectDataForLogIn();
        }


        [Test, Order(4), Category("TestsAllLoginPage"), Category("TestsLogInToAccount")]
        [TestCase(TestName = "4. Inorrect login and correct password.",
            Description = "It checks log in to the account by providing the iccorrect login and correct password. " +
                          "It checks if a notification about the wrong login and password is displayed. " +
                          "It checks if the correct text notification about the wrong login and password is displayed.")]
        public void Test4()
        {
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());

            string expectedWebsiteName = poplp.GetWebsiteTitleNameFromDictioray();
            bool expectedIsNotificationForIncorrectDataForLogInDisplayed = true;
            string expectedWebsiteNotification = poplp.GetnotificationIncorrectLoginPassword();

            poplp.SendIncorrectUsername();
            poplp.SendCorrectPassword();
            poplp.ClicksOnSinInButtons();

            string actualWebsiteName = poplp.GetWebsiteTitle();
            bool isActualNotificationForIncorrectDataForLogInDisplayed = poplp.IsNotificationForIncorrectDataForLogInDisplayed();
            string actualWebsiteNotification = poplp.GetNotificationForIncorrectDataForLogIn();
        }


        [Test, Order(5), Category("TestsAllLoginPage"), Category("TestsLogInToAccount")]
        [TestCase(TestName = "5. Empty login and password.",
            Description = "It checks to log in to the account by not providing the login and password. " +
                          "It checks if a notification about the wrong login and password is displayed. " +
                          "It checks if the correct text notification about the wrong login and password is displayed.")]
        public void Test5()
        {
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());    

            string expectedWebsiteName = poplp.GetWebsiteTitleNameFromDictioray();
            bool expectedIsNotificationForIncorrectDataForLogInDisplayed = true;
            string expectedWebsiteNotification = poplp.GetnotificationIncorrectLoginPassword();

            poplp.ClicksOnSinInButtons();

            string actualWebsiteName = poplp.GetWebsiteTitle();
            bool isActualNotificationForIncorrectDataForLogInDisplayed = poplp.IsNotificationForIncorrectDataForLogInDisplayed();
            string actualWebsiteNotification = poplp.GetNotificationForIncorrectDataForLogIn();
        }


        [Test, Order(6), Category("TestsAllLoginPage"), Category("TestsLogInToAccount")]
        [TestCase(TestName = "6. Empty login and correct password.",
                    Description = "It checks to log in to the account by not providing the login and correct password. " +
          "It checks if a notification about the wrong login and password is displayed. " +
          "It checks if the correct text notification about the wrong login and password is displayed.")]
        public void Test6()
        {
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(driver.Value);

            string expectedWebsiteName = poplp.GetWebsiteTitleNameFromDictioray();
            bool expectedIsNotificationForIncorrectDataForLogInDisplayed = true;
            string expectedWebsiteNotification = poplp.GetnotificationIncorrectLoginPassword();

            poplp.SendCorrectPassword();
            poplp.ClicksOnSinInButtons();

            string actualWebsiteName = poplp.GetWebsiteTitle();
            bool isActualNotificationForIncorrectDataForLogInDisplayed = poplp.IsNotificationForIncorrectDataForLogInDisplayed();
            string actualWebsiteNotification = poplp.GetNotificationForIncorrectDataForLogIn();
        }


        [Test, Order(7), Category("TestsAllLoginPage"), Category("TestsLogInToAccount")]
        [TestCase(TestName = "7. Correct login and empty password.",
            Description = "It checks to log in to the account by providing the correct login and empty password. " +
                          "It checks if a notification about the wrong login and password is displayed. " +
                          "It checks if the correct text notification about the wrong login and password is displayed.")]
        public void Test7()
        {
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());

            string expectedWebsiteName = poplp.GetWebsiteTitleNameFromDictioray();
            bool expectedIsNotificationForIncorrectDataForLogInDisplayed = true;
            string expectedWebsiteNotification = poplp.GetnotificationIncorrectLoginPassword();

            poplp.SendCorrectUsername();
            poplp.ClicksOnSinInButtons();

            string actualWebsiteName = poplp.GetWebsiteTitle();
            bool isActualNotificationForIncorrectDataForLogInDisplayed = poplp.IsNotificationForIncorrectDataForLogInDisplayed();
            string actualWebsiteNotification = poplp.GetNotificationForIncorrectDataForLogIn();
        }


        [Test, Order(8), Category("TestsAllLoginPage"), Category("TestsLogInToAccount")]
        [TestCase(TestName = "8. Empty login and incorrect password.",
            Description = "It checks to log in to the account by not providing the login and incorrect password. " +
                          "It checks if a notification about the wrong login and password is displayed. " +
                          "It checks if the correct text notification about the wrong login and password is displayed.")]
        public void Test8()
        {
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());

            string expectedWebsiteName = poplp.GetWebsiteTitleNameFromDictioray();
            bool expectedIsNotificationForIncorrectDataForLogInDisplayed = true;
            string expectedWebsiteNotification = poplp.GetnotificationIncorrectLoginPassword();

            poplp.SendIncorrectPassword();
            poplp.ClicksOnSinInButtons();

            string actualWebsiteName = poplp.GetWebsiteTitle();
            bool isActualNotificationForIncorrectDataForLogInDisplayed = poplp.IsNotificationForIncorrectDataForLogInDisplayed();
            string actualWebsiteNotification = poplp.GetNotificationForIncorrectDataForLogIn();
        }


        [Test, Order(9), Category("TestsAllLoginPage"), Category("TestsLogInToAccount")]
        [TestCase(TestName = "9. Incorrect login and empty password.",
            Description = "It checks to log in to the account by providing the incorrect login and empty password. " +
                          "It checks if a notification about the wrong login and password is displayed. " +
                          "It checks if the correct text notification about the wrong login and password is displayed.")]
        public void Test9()
        {
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());

            string expectedWebsiteName = poplp.GetWebsiteTitleNameFromDictioray();
            bool expectedIsNotificationForIncorrectDataForLogInDisplayed = true;
            string expectedWebsiteNotification = poplp.GetnotificationIncorrectLoginPassword();

            poplp.SendIncorrectUsername();
            poplp.ClicksOnSinInButtons();

            string actualWebsiteName = poplp.GetWebsiteTitle();
            bool isActualNotificationForIncorrectDataForLogInDisplayed = poplp.IsNotificationForIncorrectDataForLogInDisplayed();
            string actualWebsiteNotification = poplp.GetNotificationForIncorrectDataForLogIn();
        }


        //--- Tests - log in to the account <- end

        //--- Tests - radio buttons (admin & user) -> start
        
        [Test, Order(10), Category("TestsAllLoginPage"), Category("TestsRadioButtonVerification")]
        [TestCase(TestName = "10. It checks the default setup for radio buttons.",
            Description = "It checks the default setup for radio buttons. A radio button ADMIN is selected at the beginning." +
                          "A radio button USER is not selected. ")]
        public void Test10()
        {
            bool expectedIsRadioButtonAdminSelected = true;
            bool expectedIsRadioButtonUserSelected = false;

            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver()); 
            
            bool actualIsRadioButtonAdminSelected = poplp.IsRadioButtonAdminSelected();
            bool actualIsRadioButtonUserSelected = poplp.IsRadioButtonUserSelected();
        }


        [Test, Order(11), Category("TestsAllLoginPage"), Category("TestsRadioButtonVerification")]
        [TestCase(TestName = "11. It checks if the radio button ADMIN is selected when the user clicks the button CANCEL the popup.",
            Description = "It checks if the radio button ADMIN is selected when the user clicks the button CANCEL the popup. " +
                          "After the user chooses the option USER on the login view.")]
        public void Test11()
        {
            bool expectedIsRadioButtonAdminSelected = true;
            bool expectedIsRadioButtonUserSelected = false;

            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());

            poplp.ClickRadioButtonUser();
            poplp.ClickRadioButtonUserPopUpCancel();

            bool actualIsRadioButtonAdminSelected = poplp.IsRadioButtonAdminSelected();
            bool actualIsRadioButtonUserSelected = poplp.IsRadioButtonUserSelected();
        }


        [Test, Order(12), Category("TestsAllLoginPage"), Category("TestsRadioButtonVerification")]
        [TestCase(TestName = "12. It checks if the radio button USER is selected when the user clicks the button OKEY the popup.",
            Description = "It checks if the radio button USER is selected when the user clicks the button OKEY the popup. " +
                          "After the user chooses the option USER on the login view.")]
        public void Test12()
        {
            bool expectedIsRadioButtonAdminSelected = false;
            bool expectedIsRadioButtonUserSelected = true;

            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());

            poplp.ClickRadioButtonUser();
            poplp.ClickRadioButtonUserPopUpOkey();

            bool actualIsRadioButtonAdminSelected = poplp.IsRadioButtonAdminSelected();
            bool actualIsRadioButtonUserSelected = poplp.IsRadioButtonUserSelected();
        }


        [Test, Order(13), Category("TestsAllLoginPage"), Category("TestsRadioButtonVerification")]
        [TestCase(TestName = "13. It checks if the radio button ADMIN is selected when the user is back to this option.",
            Description = "The user selects the USER option on the login view and then presses the OKAY button on the popup. " +
                          "Finally, the user selects the option ADMIN on the login view.")]
        public void Test13()
        {
            bool expectedIsRadioButtonAdminSelected = true;
            bool expectedIsRadioButtonUserSelected = false;

            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());

            poplp.ClickRadioButtonUser();
            poplp.ClickRadioButtonUserPopUpOkey();
            poplp.ClickRadioButtonAdmin();

            bool actualIsRadioButtonAdminSelected = poplp.IsRadioButtonAdminSelected();
            bool actualIsRadioButtonUserSelected = poplp.IsRadioButtonUserSelected();
        }

        //--- Tests - radio buttons (admin & user) <- end


        //--- Tests - checkbox for agreeing to the terms -> start
        
        [Test, Order(14), Category("TestsAllLoginPage"), Category("TestsCheckboxButtonVerification")]
        [TestCase(TestName = "14. It checks the default setup for checkbox buttons.",
            Description = "It checks if, at the beginning, the checkbox is unchecked on the login view.")]
        public void Test14()
        {
            bool expectedIsCheckboxButtonChecked = false;

            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());

            bool actualIsCheckboxButtonChecked = poplp.IsCheckboxSelected();
        }


        [Test, Order(15), Category("TestsAllLoginPage"), Category("TestsCheckboxButtonVerification")]
        [TestCase(TestName = "15. It checks if the button is marked when the user clicks the checkbox button.",
            Description = "It checks if the button is marked when the user clicks the checkbox button.")]
        public void Test15()
        {
            bool expectedIsCheckboxButtonChecked = true;

            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());

            poplp.ClickOnCheckboxForAgreeTerms();

            bool actualIsCheckboxButtonChecked = poplp.IsCheckboxSelected();
        }


        [Test, Order(16), Category("TestsAllLoginPage"), Category("TestsCheckboxButtonVerification")]
        [TestCase(TestName = "16. It checks if the button is unmarked when the user double-clicks the checkbox button.",
            Description = "It checks if the button is unmarked when the user double-clicks the checkbox button.")]
        public void Test16()
        {
            bool expectedIsCheckboxButtonChecked = true;

            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            PageObjectsPracticeLoginPage poplp = new PageObjectsPracticeLoginPage(GetDriver());

            poplp.ClickOnCheckboxForAgreeTerms();
            poplp.ClickOnCheckboxForAgreeTerms();

            bool actualIsCheckboxButtonChecked = poplp.IsCheckboxSelected();
        }

        //--- Tests - checkbox for agreeing to the terms <- end

        //--- Tests - select user type from dropdown list  -> start


        //--- Tests - select user type from dropdown list <- end
    }
}
