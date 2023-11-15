using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeThisTime_v2.testDataJSON
{
    public class JsonReader
    {
        public JsonReader()
        {


        }

        public void extractData()
        {
            String myJsonString = File.ReadAllText("utilities/testData.json");

            var jsonObject = JToken.Parse(myJsonString);
            Console.WriteLine(jsonObject.SelectToken("username").Value<string>());
        }




    }
}
