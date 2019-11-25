using System;

namespace TheTimeTableExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;

            num1 = 1;
            num2 = 0;
            result = 0;
            for (int count = 0; count < 10; count++)
            {
                num2 = num2 + 1;
                result = num1 * num2;
                Console.WriteLine(num1 + "*" + num2 + "=" + result);
            }


            Console.WriteLine("\n");
            num1 = 2;
            num2 = 0;
            result = 0;
            for (int count2 = 0; count2 < 10; count2++)
            {
                num2 = num2 + 1;
                result = num1 * num2;
                Console.WriteLine(num1 + "*" + num2 + "=" + result);

            }

            for (int i =1; i<=10;i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.Write("\n");
            }



            Console.ReadLine();
        }
    }
}
