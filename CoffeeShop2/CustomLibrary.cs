using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop2
{
    class CustomLibrary
    {
        public static bool CheckTextisNumber(string passedValue)
        {
            bool isNumber;
            try
            {
                if (passedValue.Equals(".") || passedValue.Equals("")) isNumber = true;
                else isNumber = decimal.TryParse(passedValue, out decimal number3);                  
            }
            catch (Exception)
            {
                isNumber = false;
            }
            return isNumber;
        }
    }
}
