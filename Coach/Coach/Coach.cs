using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coach
{
    public class Coach
    {
        private Person[] contents = new Person[52]; //array
        public int NextFreeLocation = 0;


        //Add Person
        public bool AddPerson(Person Passanger)//makes new person
        {
            if (NextFreeLocation > 51)
            {
                return false;
            }

            contents[NextFreeLocation] = Passanger; //selects the number in 10 which is currently 0, adds it to the array in line 9, in a way it adds the "next free location" to the array
            NextFreeLocation = NextFreeLocation + 1;
            return true;

        } 


        public int GetNumOfPassengers()
        {
            return NextFreeLocation; //returns the amount of people who are on the bus
        }
        //Remove Person
        public bool RemovePerson(string theName)
        {
            int location = GetPassanger(theName);
            if (location == -1)
            {
                return false;
            }
            NextFreeLocation--;
            contents[location] = contents[NextFreeLocation];
            return true;
        }
        public int GetPassanger(string theName)
        {
            for (int i = 0; i < NextFreeLocation; i++)
            {
                if (theName == contents[i].GetName())
                {
                    return i;
                }
            }
            return -1;
        }
        public void DisplayCoach ()
        {
            Console.WriteLine(contents[NextFreeLocation]);
            contents.ToList().ForEach(NextFreeLocation => Console.WriteLine(NextFreeLocation.ToString()));
        }

    }
}
