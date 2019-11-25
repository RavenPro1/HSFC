using System;
using System.Collections.Generic;
using System.Text;

namespace PersonProject
{
    public class Person
    {

        private String name = "";
        private Address livesAt;

        private int age = 0;
        public void SetName(string nameToSet)
        {
            name = nameToSet;
        }
        public void SetAge(int ageToSet)
        {
            age = ageToSet;
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }

        public void SetlivesAt(Address TheAddress)
        {
            livesAt = TheAddress;
        }
        public Address GetlivesAt()
        {
            return livesAt;
        }

        public override string ToString()
        {
            return this.GetName() + " is aged " + this.GetAge() + " and lives at " + this.livesAt;
        }

    }
}
