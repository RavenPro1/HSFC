using System;
using System.Threading;
namespace Coach
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach MyCoach = new Coach();

            int menu;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Add Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Check all Passengers");
                menu = Convert.ToInt32(Console.ReadLine());


                if (menu == 1)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        Person p = new Person();
                        Console.WriteLine("Enter Name");
                        p.SetName(Console.ReadLine());

                        if (MyCoach.AddPerson(p) == true)
                        {
                            Console.WriteLine("Success");
                        }
                        else
                        {
                            Console.WriteLine("Failure");
                        }
                    }
                }
                else if (menu == 2)
                {
                    Console.WriteLine("write the name of a Person you want to be removed");
                    if (MyCoach.RemovePerson(Console.ReadLine()) == true)
                    {
                        Console.WriteLine("Person removed");
                    }
                    else
                    {
                        Console.WriteLine("Person not removed/ Not found");
                    }
                }
                else if (menu == 3)
                {
                    MyCoach.DisplayCoach();
                    Thread.Sleep(4000);
                }
            } while (menu != 4);

            Console.ReadLine();


























            /*
            for (int i = 0; i < 1; i++)
            {
                Person p = new Person();
                Console.WriteLine("Enter Name");
                p.SetName(Console.ReadLine());

                if (MyCoach.AddPerson(p) == true)
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Failure");
                }
            }
            if (MyCoach.RemovePerson(Console.ReadLine()) == true)
            {
                Console.WriteLine("Person removed");
            }
            else
            {
                Console.WriteLine("Person not removed/ Not found");
            }
            */
        }
    }
}
