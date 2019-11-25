using System;

namespace PersonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Person 1 Name
            Person p1 = new Person();
            p1.SetName("PeanutButter");
            p1.GetName();
            /*
            //Person 1 age
            p1.SetAge(16);
            Console.WriteLine("Type Person 1 age");
            p1.SetAge(Convert.ToInt32(Console.ReadLine()));

            // Print out person 1 name and age
            Console.WriteLine(p1.GetName() + " is aged " + p1.GetAge());

            Console.WriteLine("\n");

            Console.WriteLine("\n");
            /*
            Console.WriteLine("Name: " + p2.GetName());
            Console.WriteLine("Age: " + p2.GetAge());
            Console.WriteLine("Street: " + a1.GetStreet());
            Console.WriteLine("PostCode: " + a1.GetPostcode());
            Console.WriteLine("City: " + a1.GetCity());
            Console.WriteLine("House No: " + a1.GetHouseNum());
            */
            //Console.WriteLine(p2.GetName() + " is aged " + p2.GetAge());

            /*
            // Person 2 Name
            Console.WriteLine("Write person name");
            Person p2 = new Person();
            p2.SetName(Console.ReadLine());
            //person 2 age
            p2.SetAge(1);
            Console.WriteLine("Type Person age");
            p2.SetAge(Convert.ToInt32(Console.ReadLine()));
            //Address
            Address a1 = new Address();
            p2.SetlivesAt(a1);
            Console.Write("Type the name of the street: ");
            a1.SetStreet(Console.ReadLine());
            Console.Write("Type the postcode: ");
            a1.SetPostcode(Console.ReadLine());
            Console.Write("Type the city you live in: ");
            a1.SetCity(Console.ReadLine());
            Console.Write("Your House Number: ");
            a1.SetHouseNum(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine(p2);
            */
            //Array for the subject
            Person[] Computing = new Person[22];
            Subject[] Class = new Subject[22];
            Person p1;
            Subject s1;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Please enter the name");
                p1 = new Person();
                p1.SetName(Console.ReadLine());
                Computing[i] = p1;
                Computing[i].SetAge(18);
            }
            for (int i=0;i<2;i++)
            {
                Computing[i].SetAge(Computing[i].GetAge() + 1);
            }
            for (int i=0;i<2;i++)
            {
                Console.WriteLine("Please enter the subject(s),Maths, English, Science " + i);
                s1 = new Subject();
                s1.SetSubject(Console.ReadLine());
                Class[i] = s1;
                Console.WriteLine(s1.GetSubject());
            }
            Console.ReadLine();
        }
    }
}
