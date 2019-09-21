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

        public static bool HasDuplicates(List<Students> list)
        {
            if (list.Count == 0) return false;
            var allUniqueID = list.GroupBy(x => x.id).All(g => g.Count() == 1);
            var allUniqueMobile = list.GroupBy(x => x.mobile).All(g => g.Count() == 1);
            if (allUniqueID && allUniqueMobile) return true;
            return false;
        }

        

        public static Students FindMaxMinInList(List<Students> list, string searchType)
        {
            double result = 0;
            if (searchType == "max") result = list.Max(i => i.gpa);
            if (searchType == "min") result = list.Min(i => i.gpa);
            var student = list.First(x => x.gpa == result);
            return student;
        }

        
        public static double FindAvgOfList(List<Students> list)
        {
            if (list.Count == 0) return 0;
            return list.Select(r => r.gpa).Average(); ;
        }


        public static double FindTotalOfList(List<Students> list)
        {
            if (list.Count == 0) return 0;
            return list.Sum(r => r.gpa);
        }

    }
}
