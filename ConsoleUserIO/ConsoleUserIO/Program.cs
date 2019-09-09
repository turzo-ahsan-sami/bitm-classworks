using System;

namespace ConsoleUserIO
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDetails user = new UserDetails();

            // Input

            Console.WriteLine("Input Name : ");
            user.User_name = Console.ReadLine();
            Console.WriteLine("Input Age : ");
            user.User_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Phone : ");
            user.User_phone = Console.ReadLine();
            Console.WriteLine("Input Address : ");
            user.User_address = Console.ReadLine();

            // Output

            Console.WriteLine("Name : " + user.User_name);
            Console.WriteLine("Age : " + user.User_age);
            Console.WriteLine("Phone : " + user.User_phone);
            Console.WriteLine("Address : " + user.User_address);

            Console.ReadKey();
        }
    }
}
