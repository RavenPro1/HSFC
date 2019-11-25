using System;

namespace The_Number_Game
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int intGuess;
            int intNumber;
            int intCount;
            intNumber = rnd.Next(1, 11);
            Console.WriteLine("Enter your guess between 1 and 10");
            intCount = 0;

            do
            {
                intGuess = Convert.ToInt32(Console.ReadLine());

                if (intGuess > intNumber)
                {
                    Console.WriteLine("Too High");
                    intCount = intCount + 1;
                }
                if (intGuess < intNumber)
                {
                    Console.WriteLine("Too Low");
                    intCount = intCount + 1;
                }
                if (intGuess == intNumber)
                {
                    intCount = intCount + 1;
                    Console.WriteLine("You got it, it took you " + intCount + " try(s) to guess the right number");
                }
            } while (intGuess != intNumber);


            Console.ReadLine();
        }
    }
}