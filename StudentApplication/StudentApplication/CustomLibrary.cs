using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class CustomLibrary
    {
        public static bool IsNumber(string passedValue)
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

        public static bool HasDuplicateContacts(List<Students> list, string key, string value)
        {
            if (list.Count == 0 || value == "") return false;                  

            return false;
        }

        

        public static double FindMaxInList(List<Students> list, string key)
        {
            if (list.Count == 0 || key == "") return 0;

            return list.Select(r => r.gpa)
                               .Where(price => price != null)
                               .Max(price => price.AverageNightlyRate);

           
        }

        public static double FindMinInList(List<Students> list, string key)
        {
            if (list.Count == 0 || key == "") return 0;

            return 0;
        }

        public static double FindAvgOfList(List<Students> list, string key)
        {
            if (list.Count == 0 || key == "") return 0;

            return 0;
        }

        
    }
}
