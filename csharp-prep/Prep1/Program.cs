using System;

namespace Prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name? " );
            string name = Console.Readline();
            Console.WriteLine("What is your last name? " );
            string lastname = Console.Readline();
            
            Console.WriteLine();
            Console.WriteLine($"Your name is "{lastname}", "{name}" "{lastname}".");

            // Write your code here
        }
    }
}
