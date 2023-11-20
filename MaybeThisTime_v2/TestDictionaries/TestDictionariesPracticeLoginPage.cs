using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeThisTime_v2.TestDictionaries
{
    internal class TestDictionariesPracticeLoginPage
    {

        public static Dictionary<int, string> DistionaryPracticeLoginPage()
        {
            string websiteTitleName = "LoginPage Practise | Rahul Shetty Academy";
            string notificationIncorrectLoginPassword = "Incorrect username/password.";

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
           
            dictionary.Add(1, websiteTitleName);
            dictionary.Add(2, notificationIncorrectLoginPassword);

            return dictionary;
        }


    }
}
