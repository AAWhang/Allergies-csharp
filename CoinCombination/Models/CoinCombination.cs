using System;
using System.Collections.Generic;

namespace CoinCombination.Models
{
    public class changeCalc
    {
        public int allergies;

        public string AllergyCalc(int allergyScore)
        {
            allergies = allergyScore;
            List<string> allergyList = new List<string> {};
            if (allergies >= 128)
            {
            allergyList.Add(allergy(128,"Cats"));
            } 
            if (allergies >= 64)
            {
            allergyList.Add(allergy(64,"pollen"));
            } 
            if (allergies >= 32)
            {
            allergyList.Add(allergy(32,"chocolate"));
            } 
            if (allergies >= 16)
            {
            allergyList.Add(allergy(16,"tomatoes"));
            } 
            if (allergies >= 8)
            {
            allergyList.Add(allergy(8,"strawberries"));
            } 
            if (allergies >= 4)
            {
            allergyList.Add(allergy(4,"shellfish"));
            } 
            if (allergies >= 2)
            {
            allergyList.Add(allergy(2,"peanuts"));
            } 
            if (allergies >= 1)
            {
            allergyList.Add(allergy(1,"eggs"));
            }

            string output = String.Join(" ", allergyList.ToArray());

            return output;        

        }

        public string allergy(int anum, string condition) 
        {
            if (allergies >= anum) {
                allergies = allergies - anum;
                return condition;
            } else {
                return "";
            }
        }
    }
}