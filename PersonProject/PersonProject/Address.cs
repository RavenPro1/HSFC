using System;
using System.Collections.Generic;
using System.Text;

namespace PersonProject
{
    public class Address
    {
        private string aStreet, Postcode, City, HouseNum;

        public void SetStreet (string TheStreet)
        {
            aStreet = TheStreet;
        }
        public string GetStreet()
        {
            return aStreet;
        }

        public void SetPostcode(string ThePostcode)
        {
            Postcode = ThePostcode;
        }
        public string GetPostcode()
        {
            return Postcode;
        }

        public void SetCity(string TheCity)
        {
            City = TheCity;
        }
        public string GetCity()
        {
            return City;
        }

        public void SetHouseNum(string TheHouseNum)
        {
            HouseNum = TheHouseNum;
        }
        public string GetHouseNum()
        {
            return HouseNum;
        }
        public override string ToString()
        {
            return aStreet+ ", " + HouseNum + ", " + City + ", " + Postcode;
        }
    }
}
