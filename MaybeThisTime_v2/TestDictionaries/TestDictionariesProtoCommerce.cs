using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeThisTime_v2.TestDictionaries
{
    internal class TestDictionariesProtoCommerce
    {
        public static Dictionary<int, string> DictionaryProtoCommerce()
        {
            string websiteTitleName = "ProtoCommerce";

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary[1] = websiteTitleName;

            return dictionary;
        }

    }
}
