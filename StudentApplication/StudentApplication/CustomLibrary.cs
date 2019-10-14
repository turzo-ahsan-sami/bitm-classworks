using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentApplication
{
    internal class CustomLibrary
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

        public static bool HasDuplicateID(List<StudentInformation> list, string id)
        {
            if (list.Count == 0) return false;
            return list.Exists(r => r.id == id);
        }

        public static bool HasDuplicateMobile(List<StudentInformation> list, string mobile)
        {
            if (list.Count == 0) return false;
            return list.Exists(r => r.mobile == mobile);
        }

        public static StudentInformation FindMaxInList(List<StudentInformation> list)
        {
            if (list.Count == 0) return null;
            double result = 0;
            result = list.Max(i => i.gpa);
            var student = list.First(x => x.gpa == result);
            return student;
        }

        public static StudentInformation FindMinInList(List<StudentInformation> list)
        {
            if (list.Count == 0) return null;
            double result = 0;
            result = list.Min(i => i.gpa);
            var student = list.First(x => x.gpa == result);
            return student;
        }

        public static double FindAvgOfList(List<StudentInformation> list)
        {
            if (list.Count == 0) return 0;
            return list.Select(r => r.gpa).Average(); ;
        }

        public static double FindTotalOfList(List<StudentInformation> list)
        {
            if (list.Count == 0) return 0;
            return list.Sum(r => r.gpa);
        }
    }
}