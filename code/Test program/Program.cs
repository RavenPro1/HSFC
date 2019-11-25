using System;

namespace Test_program
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age = 0;
            int year = 0;

            Console.Write("Hey, Whats your name?:");
            name = Console.ReadLine();
            Console.Write("hey, I'm Alan. How old are you? :");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the current year");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So {0}. Your age is {1}, and you were born in {2}",
                name, age, year - age);


            Console.ReadLine();
        
        }
    }
}
