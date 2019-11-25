using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            // Program 1
            Console.WriteLine("Enter 3 integers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is" + (a + b + c));


            //Program 2
            Console.WriteLine("Enter 3 test marks");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The average is" + ((a + b + c)/3));

            //Program 3
            Console.WriteLine("Enter Length, Depth and Height of a fish tank in CM, to calculate the volume of water");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The volume of in litres is " + ((a * b * c)/1000));
            Console.WriteLine("The volume in gallons " + (((a * b * c) / 1000) * 0.264));

            Console.ReadLine();
        }
    }
}
