using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using MaybeThisTime_v2.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Collections;
using MaybeThisTime_v2.TestDictionaries;

namespace MaybeThisTime_v2.PageObjects.PageObjectsPracticeLoginPage
{
    public class PageObjectsPracticeLoginPage
    {

        private IWebDriver _driver;
        private Dictionary<int, string> _dictionaryLoginPage = TestDictionariesPracticeLoginPage.DistionaryPracticeLoginPage();
        private Dictionary<int, string> _dictionaryProtoCommerce = TestDictionariesProtoCommerce.DictionaryProtoCommerce();

        public PageObjectsPracticeLoginPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        // OBJECTS -> start

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement _username;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement _password;

        [FindsBy(How = How.XPath, Using = "//input[@value='admin'][@type='radio']")]
        private IWebElement _radioButtonAdmin;

        [FindsBy(How = How.CssSelector, Using = "input[type='radio']")]
        private IList<IWebElement>  _radioButtonsList;

        [FindsBy(How = How.XPath, Using = "//input[@value='user'][@type='radio']")]
        private IWebElement _radioButtonUser;

        [FindsBy(How = How.XPath, Using = "//div[@class='form-group'][5]/label/span/input")]
        private IWebElement _checkboxAgreeTerms;

        [FindsBy(How = How.Id, Using = "okayBtn")]
        private IWebElement _popupbuttonOkey;

        [FindsBy(How = How.Id, Using = "cancelBtn")]
        private IWebElement _popupbuttonCancel;

        [FindsBy(How = How.Id, Using = "signInBtn")]
        private IWebElement _buttonSignIn;

        [FindsBy(How = How.XPath, Using = "//form[@id='login-form']/div")]
        private IWebElement _notificationIncorrectLoginOrPassword;

        // OBJECTS <- end
        //--------------------------------------------------------------------------------------------------------------------------------------

        // ACTIONS username -> start
        // username = rahulshettyacademy,   

        public void ClickOnFieldUsername()
        {
            CommonFunctions.ElementClick(_username);
        }

        // future -> get data from .json
        public string[] SetUpArrayWithUsername()
        {
            string correct = "rahulshettyacademy";
            string incorrect = "rahulshetty";
            string[] usernames = new string[2];
            usernames[0] = correct;
            usernames[1] = incorrect;
            return usernames;
        }

        /// <summary>
        /// 1 = correct username,
        /// 2 = incorrect username
        /// </summary>
        /// <param name="numberForUsername"></param>
        public void SendUsername(int numberForUsername)
        {
            string[] usernames = SetUpArrayWithUsername();
            string username = usernames[numberForUsername];
            ClickOnFieldUsername();
            CommonFunctions.SendText(_username, username);
        }

        public void SendCorrectUsername()
        {
            SendUsername(0);
        }

        public void SendIncorrectUsername()
        {
            SendUsername(1);
        }


        // ACTIONS username  <- end
        //--------------------------------------------------------------------------------------------------------------------------------------

        // ACTIONS password -> start
        // password = learning,   
        public void ClickOnFieldPassword()
        {
            CommonFunctions.ElementClick(_password);
        }

        // future -> get data from .json
        public string[] SetUpArrayWithPasswords()
        {
            string correct = "learning";
            string incorrect = "rahulshetty1";
            string[] usernames = new string[2];
            usernames[0] = correct;
            usernames[1] = incorrect;
            return usernames;
        }

        /// <summary>
        /// 1 = correct username,
        /// 2 = incorrect username
        /// </summary>
        /// <param name="numberForUsername"></param>
        public void SendPassword(int numberForPassword)
        {
            string[] passwords = SetUpArrayWithPasswords();
            string username = passwords[numberForPassword];
            ClickOnFieldUsername();
            CommonFunctions.SendText(_password, username);
        }

        public void SendCorrectPassword()
        {
            SendPassword(0);
        }

        public void SendIncorrectPassword()
        {
            SendPassword(1);
        }


        // ACTIONS password  <- end
        //--------------------------------------------------------------------------------------------------------------------------------------

        // ACTIONS radio buttons -> start
        public void ClickRadioButtonAdmin()
        {
            TestContext.Progress.WriteLine("Click radio button admin.");
            CommonFunctions.ElementClick(_radioButtonAdmin);
        }

        public void ClickRadioButtonUser()
        {
            TestContext.Progress.WriteLine("Click radio button user.");
            CommonFunctions.ElementClick(_radioButtonUser);
        }

        public bool IsRadioButtonAdminSelected()
        {
            IWebElement radioButtonAdmin = _radioButtonsList[0];
            bool result = CommonFunctions.IsElementSelected(radioButtonAdmin);
            TestContext.Progress.WriteLine($"Is radio button admin selected: {result}");
            return result;
        }

        public bool IsRadioButtonUserSelected()
        {
            IWebElement radioButtonUser = _radioButtonsList[1];
            bool result = CommonFunctions.IsElementSelected(radioButtonUser);
            TestContext.Progress.WriteLine($"Is radio button user selected: {result}");
            return result;
        }

        // ACTIONS radio buttons <- end
        //--------------------------------------------------------------------------------------------------------------------------------------

        // ACTIONS radio buttons - user pop up -> start
        public void ClickRadioButtonUserPopUpOkey()
        {
            CommonFunctions.WaitUntilElementToBeClickable(_driver, _popupbuttonOkey, 4);
            TestContext.Progress.WriteLine("Click the button okey on the pop-up.");
            CommonFunctions.ElementClick(_popupbuttonOkey);
        }

        public void ClickRadioButtonUserPopUpCancel()
        {
            CommonFunctions.WaitUntilElementToBeClickable(_driver, _popupbuttonCancel, 4);
            TestContext.Progress.WriteLine("Click the button cancel on the pop-up.");
            CommonFunctions.ElementClick(_popupbuttonCancel);
        }
        // ACTIONS radio buttons  - user pop up <- end
        //--------------------------------------------------------------------------------------------------------------------------------------

        // ACTIONS radio buttons - user pop up -> start
        public void ClickOnCheckboxForAgreeTerms()
        {
            TestContext.Progress.WriteLine("Click checkbox for agree terms.");
            CommonFunctions.ElementClick(_checkboxAgreeTerms);
        }

        public bool IsCheckboxSelected()
        {
            bool result = CommonFunctions.IsElementSelected(_checkboxAgreeTerms);
            TestContext.Progress.WriteLine($"Is checkbox checked: {result}");
            return result;
        }

        // ACTIONS radio buttons  - user pop up <- end
        //--------------------------------------------------------------------------------------------------------------------------------------

        // ACTIONS sing in button -> start
        public void ClicksOnSinInButtons ()
        {
            TestContext.Progress.WriteLine("Click SIGN IN button.");
            CommonFunctions.ElementClick(_buttonSignIn);
        }

        // ACTIONS sign in button <- end
        //--------------------------------------------------------------------------------------------------------------------------------------


        // ACTIONS others -> start
        public string GetWebsiteTitle()
        {
            string webpageTitle = CommonFunctions.GetWebsiteTitle(_driver);
            return webpageTitle;
        }

        public bool IsNotificationForIncorrectDataForLogInDisplayed()
        {
            bool isDisplayed = CommonFunctions.IsElementDisplayed(_notificationIncorrectLoginOrPassword);
            return isDisplayed;
        }

        public string GetNotificationForIncorrectDataForLogIn()
        {
            bool isDisplayed = IsNotificationForIncorrectDataForLogInDisplayed();

            if (isDisplayed == true)
            {
                string text = _notificationIncorrectLoginOrPassword.Text;
                TestContext.Progress.WriteLine("Actual notification text: " + text);
                return text;
            }
            else
            {
                return "Notification was not displayed.";
            }           
        }

        // ACTIONS others <- end
        //--------------------------------------------------------------------------------------------------------------------------------------

        // ACTIONS dictionary data -> start
        public string GetWebsiteTitleNameFromDictioray()
        {
            //Dictionary<int, string> dictionary = TestDictionariesPracticeLoginPage.DistionaryPracticeLoginPage();
            //string websiteTitleName = dictionary[1];
            string websiteTitleName = _dictionaryLoginPage[1];
            return websiteTitleName;
        }

        public string GetnotificationIncorrectLoginPassword()
        {
            //Dictionary<int, string> dictionary = TestDictionariesPracticeLoginPage.DistionaryPracticeLoginPage();
            //string notificationIncorrectLoginPassword = dictionary[2];
            string notificationIncorrectLoginPassword = _dictionaryLoginPage[2];
            return notificationIncorrectLoginPassword;
        }

        public string GetWebsiteTitleNameFromDictiorayAfterLogIn()
        {
            //Dictionary<int, string> dictionary = TestDictionariesProtoCommerce.DictionaryProtoCommerce();
            //string websiteTitleName = dictionary[1];
            string websiteTitleName = _dictionaryProtoCommerce[1];
            return websiteTitleName;
        }
        // ACTIONS sign in button <- end
        //--------------------------------------------------------------------------------------------------------------------------------------


    }


}



// ACTIONS -> start

// ACTIONS <- end