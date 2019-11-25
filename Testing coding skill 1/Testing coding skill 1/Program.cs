using System;

namespace Testing_coding_skill_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Height, Weight;
            Console.WriteLine("Sam");
            Console.WriteLine("Enter Weight (kg) then enter Height (m2)");

            Height = Convert.ToDouble(Console.ReadLine());
            Weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your BMI is" + ((Height / Weight)));
            


            Console.ReadLine();
        }
    }
}
