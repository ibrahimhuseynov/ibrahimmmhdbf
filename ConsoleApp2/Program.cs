using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            user users = new user();
            Console.WriteLine(" enter the username :");
            users.Username = Console.ReadLine();
            Console.WriteLine("enter the password :");
            users.Password = Console.ReadLine();
            Console.WriteLine(users.Username);
            Console.WriteLine(users.Password);
            Console.Read();
        }
    }
}
