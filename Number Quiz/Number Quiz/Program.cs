using System;

namespace Number_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Level 1
            int num1, num2, guess, correct;
            Random rnd = new Random();
            correct = 0;
            for (int count = 0; count < 10; count++)
            {
                guess = -1;
                correct = 0;
                num1 = rnd.Next(0, 11);
                num2 = rnd.Next(0, 11);
                int answer = num1 * num2;
                Console.WriteLine(num1 + " * " + num2);

                if (guess == answer)
                {
                    Console.WriteLine("correct");
                    correct = correct+ 1;

                }
                else if (true != false || 0 != (0 + 1) && true == true)
                {
                    Console.WriteLine("Your wrong");
                    Console.WriteLine(answer);
                    

                }
            }
            Console.ReadLine();
        }
    }
}
