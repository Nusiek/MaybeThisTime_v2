using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using MaybeThisTime_v2.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MaybeThisTime_v2.PageObjects.PageObjectsPracticeLoginPage
{
    public class PageObjectsPracticeLoginPage
    {

        private IWebDriver _driver;

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

        [FindsBy(How = How.XPath, Using = "//input[@value='user'][@type='radio']")]
        private IWebElement _radioButtonAdmin;

        [FindsBy(How = How.XPath, Using = "//input[@value='user'][@type='radio']")]
        private IWebElement _radioButtonUser;

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
            CommonFunctions.ElementClick(_username);
        }

        // future -> get data from .json
        public string[] SetUpArrayWithPasswords()
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
        public void SendPassword(int numberForPassword)
        {
            string[] passwords = SetUpArrayWithPasswords();
            string username = passwords[numberForPassword];
            ClickOnFieldUsername();
            CommonFunctions.SendText(_username, username);
        }

        public void SendCorrectPassword()
        {
            SendUsername(0);
        }

        public void SendIncorrectPassword()
        {
            SendUsername(1);
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
        // ACTIONS radio buttons <- end
        //--------------------------------------------------------------------------------------------------------------------------------------


        // ACTIONS radio buttons - user pop up -> start
        public void ClickRadioButtonUserPopUpOkey()
        {
            TestContext.Progress.WriteLine("");
            CommonFunctions.ElementClick(_radioButtonAdmin);
        }

        public void ClickRadioButtonUserPopUpCancel()
        {
            TestContext.Progress.WriteLine("");
            CommonFunctions.ElementClick(_radioButtonAdmin);
        }
    }
    // ACTIONS radio buttons  - user pop up <- end
    //--------------------------------------------------------------------------------------------------------------------------------------


}
}


// ACTIONS -> start

// ACTIONS <- end