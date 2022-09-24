using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your grade percent? ");
            string gradueInText = Console.ReadLine();
            int grade = int.Parse(gradueInText);
            
            string letter = "";
            if (grade >= 90)
            {
                letter = "A";
            }
                
            if (grade >= 80)
            {
                letter = "B";
            }
                
            if (grade >= 70)
            {
                letter = "C";
            }
            
            if (grade >= 60)
            {
                letter = "D";
            }
                
            else
            {
                letter = "F";
            }
                
            // Stretch Challenge 1
            

            int last_digit = grade % 10;
            string sign = "";
            if (last_digit >= 7)
            {
                sign = "+";
            }
                
            if (last_digit < 3)
            {
                sign = "-";
            }
                
            else
            {
                sign = "";
            }
                

            
            // Stretch Challenge 2
            if (grade >= 93)
            {
                sign = "";
            }
                

            //Stretch Challenge 3
            if (letter == "F")
            {
                sign = "";
            }
                
            Console.WriteLine($"Your letter grade is: {letter}{sign}"); 

            if (grade >= 70)
            {
                Console.WriteLine("Congratulations! You passed the class!");
            }
                
            else
            {
                Console.WriteLine("Stay focused and you'll get it next time!");
            }
        }
    }
}
