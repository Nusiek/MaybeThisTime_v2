using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeThisTime_v2.Common
{
    public class ConvertMethods
    {
        public static int ConvertStringToInt(string text)
        {
            try
            {
                int number;
                bool isNumber = int.TryParse(text, out number);
                return number;
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
