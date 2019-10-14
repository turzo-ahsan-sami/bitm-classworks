using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformationAppWalkthrough2
{
    class Person
    {
        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Point { get; set; }

        public Person()
        {
            Point = 10;
        }

        public Person(string firstName, string middleName, string lastName): this()
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
        
        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public string GetReverseName()
        {
            return LastName + " " + MiddleName + " " + FirstName;
        }

    }
}
