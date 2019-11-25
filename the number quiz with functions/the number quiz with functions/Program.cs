using System;
using System.Threading;
namespace the_number_quiz_with_functions
{
    class Program
    {
        static void Main(string[] args)
        {

            int Level, Score, guess, num1 =0, num2=0;
            double num3=0, num4=0;
            void menu()
            {

                Console.Clear();
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulus");
                Console.WriteLine("6. Display Score");
                Console.WriteLine("7. Change Level");
                Console.WriteLine("8. Quit");

                int choice;
                choice = 0;
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                }
                if (choice == 8)
                {
                    System.Environment.Exit(1);
                }
                else if (choice == 7)
                {
                    Console.WriteLine("choose a Level between 1-5");
                    Level = Convert.ToInt32(Console.ReadLine());
                    menu();
                    //Console.WriteLine(Level);
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Your Score is");
                    Console.WriteLine(Score);
                    Thread.Sleep(4000);
                    menu();
                }
                else if (choice == 5)
                {
                    Modulo();
                }
                else if (choice == 4)
                {
                    Division();
                }
                else if (choice == 3)
                {
                    Multiply();
                }
                else if (choice == 2)
                {
                    subtraction();
                }
                else if (choice == 1)
                {
                    Addition();
                }



            }
            void Multiply()
            {
                for (int count = 0; count < 10; count++)
                {
                    Random rnd = new Random();
                    if (Level == 1)
                    {
                        num1 = rnd.Next(0, 11);
                        num2 = rnd.Next(0, 11);
                    }
                    else if (Level == 2)
                    {
                        num1 = rnd.Next(10, 21);
                        num2 = rnd.Next(10, 21);
                    }
                    else if (Level == 3)
                    {
                        num1 = rnd.Next(20, 31);
                        num2 = rnd.Next(20, 31);
                    }
                    else if (Level == 4)
                    {
                        num1 = rnd.Next(30, 41);
                        num2 = rnd.Next(30, 41);
                    }
                    else if (Level == 5)
                    {
                        num1 = rnd.Next(40, 51);
                        num2 = rnd.Next(40, 51);
                    }
                    guess = -10000;


                    int answer = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2);
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == answer)
                    {
                        Console.WriteLine("correct");
                        Score = Score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Your wrong");
                        Console.WriteLine(answer);


                    }

                }
                menu();
            }
            void subtraction()
            {

                for (int count = 0; count < 10; count++)
                {
                    Random rnd = new Random();
                    if (Level == 1)
                    {
                        num1 = rnd.Next(0, 11);
                        num2 = rnd.Next(0, 11);
                    }
                    else if (Level == 2)
                    {
                        num1 = rnd.Next(10, 21);
                        num2 = rnd.Next(10, 21);
                    }
                    else if (Level == 3)
                    {
                        num1 = rnd.Next(20, 31);
                        num2 = rnd.Next(20, 31);
                    }
                    else if (Level == 4)
                    {
                        num1 = rnd.Next(30, 41);
                        num2 = rnd.Next(30, 41);
                    }
                    else if (Level == 5)
                    {
                        num1 = rnd.Next(40, 51);
                        num2 = rnd.Next(40, 51);
                    }
                    guess = -10000;


                    int answer = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2);
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == answer)
                    {
                        Console.WriteLine("correct");
                        Score = Score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Your wrong");
                        Console.WriteLine(answer);


                    }

                }
                menu();
            }
            void Addition()
            {

                for (int count = 0; count < 10; count++)
                {
                    Random rnd = new Random();
                    if (Level == 1)
                    {
                        num1 = rnd.Next(0, 11);
                        num2 = rnd.Next(0, 11);
                    }
                    else if (Level == 2)
                    {
                        num1 = rnd.Next(10, 21);
                        num2 = rnd.Next(10, 21);
                    }
                    else if (Level == 3)
                    {
                        num1 = rnd.Next(20, 31);
                        num2 = rnd.Next(20, 31);
                    }
                    else if (Level == 4)
                    {
                        num1 = rnd.Next(30, 41);
                        num2 = rnd.Next(30, 41);
                    }
                    else if (Level == 5)
                    {
                        num1 = rnd.Next(40, 51);
                        num2 = rnd.Next(40, 51);
                    }
                    guess = -10000;


                    int answer = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2);
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == answer)
                    {
                        Console.WriteLine("correct");
                        Score = Score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Your wrong");
                        Console.WriteLine(answer);


                    }

                }
                menu();
            }
            void Division()
            {

                for (int count = 0; count < 10; count++)
                {
                    Random rnd = new Random();
                    if (Level == 1)
                    {
                        num1 = rnd.Next(0, 11);
                        num2 = rnd.Next(0, 11);
                    }
                    else if (Level == 2)
                    {
                        num1 = rnd.Next(10, 21);
                        num2 = rnd.Next(10, 21);
                    }
                    else if (Level == 3)
                    {
                        num1 = rnd.Next(20, 31);
                        num2 = rnd.Next(20, 31);
                    }
                    else if (Level == 4)
                    {
                        num1 = rnd.Next(30, 41);
                        num2 = rnd.Next(30, 41);
                    }
                    else if (Level == 5)
                    {
                        num1 = rnd.Next(40, 51);
                        num2 = rnd.Next(40, 51);
                    }
                    guess = -10000;


                    double answer = num3 / num4;
                    Console.WriteLine(num3 + " / " + num4);
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == answer)
                    {
                        Console.WriteLine("correct");
                        Score = Score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Your wrong");
                        Console.WriteLine(answer);


                    }

                }
                menu();
            }
            void Modulo()
            {

                for (int count = 0; count < 10; count++)
                {
                    Random rnd = new Random();
                    if (Level == 1)
                    {
                        num1 = rnd.Next(6, 12);
                        num2 = rnd.Next(0, 5);
                    }
                    else if (Level == 2)
                    {
                        num1 = rnd.Next(18, 24);
                        num2 = rnd.Next(12, 18);
                    }
                    else if (Level == 3)
                    {
                        num1 = rnd.Next(30, 36);
                        num2 = rnd.Next(24, 30);
                    }
                    else if (Level == 4)
                    {
                        num1 = rnd.Next(42, 48);
                        num2 = rnd.Next(36, 42);
                    }
                    else if (Level == 5)
                    {
                        num1 = rnd.Next(54, 60);
                        num2 = rnd.Next(48, 54);
                    }
                    guess = -10000;


                    int answer = num1 % num2;
                    Console.WriteLine(num1 + " % " + num2);
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == answer)
                    {
                        Console.WriteLine("correct");
                        Score = Score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Your wrong");
                        Console.WriteLine(answer);


                    }

                }
                menu();
            }

            Score = 0;
            Level = 1;
            Console.ReadLine();
            menu();
            Console.ReadLine();








            Console.ReadLine();





            Console.ReadLine();


        }
    }
}
