using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUserIO
{
    class UserDetails
    {

        private string user_name;
        private int user_age;
        private string user_phone;
        string user_address;

        public string User_name { get => user_name; set => user_name = value; }
        public int User_age { get => user_age; set => user_age = value; }
        public string User_phone { get => user_phone; set => user_phone = value; }
        public string User_address { get => user_address; set => user_address = value; }

    }
}
