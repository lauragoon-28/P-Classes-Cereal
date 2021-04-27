using System;
using System.Collections.Generic;
using System.IO;

namespace P_Classes__Cereal
{
    class Program
    {
        static void Main(string[] args)
        {

            //We want to read in a data set of Cereal information and help answer a few questions for the user.  
            //The application should output all of the Cereal information that have a serving size that is 1 cup or more.  
            //After you output all those cereals, we also need to inform them which Cereals have 100 calories or less per serving.

            string[] productInfo = File.ReadAllLines("Cereal_Data.txt");
            //for (int i = 0; i < productInfo.Length; i++)
            //{
            //    Console.WriteLine(productInfo[i]);
            //}

            List<Cereal> cereals = new List<Cereal>();

            for (int i = 1; i < productInfo.Length; i++)
            {
                string[] currentProduct = productInfo[i].Split('|');
                Cereal c1 = new Cereal();
                c1.Name = currentProduct[0];
                c1.Manufacturer = currentProduct[1];
                c1.Calories = Convert.ToDouble(currentProduct[2]);
                c1.Cups = Convert.ToDouble(currentProduct[3]);
                cereals.Add(c1);
            }

            Console.WriteLine("Cereals with a serving size with 1 cup or more:");
            for (int i = 0; i < cereals.Count; i++)
            {
                if (cereals[i].Cups >= 1)
                {
                    Console.WriteLine($"    - Name: {cereals[i].Name}, Manufacturer: {cereals[i].Manufacturer}, Calories: {cereals[i].Calories}, Cups: {cereals[i].Cups}");
                }
            }

            Console.WriteLine("Cereals with 100 calories or less per serving:");
            for (int i = 0; i < cereals.Count; i++)
            {
                if (cereals[i].Calories <= 100)
                {
                    Console.WriteLine($"    - Name: {cereals[i].Name}, Manufacturer: {cereals[i].Manufacturer}, Calories: {cereals[i].Calories}, Cups: {cereals[i].Cups}");
                }
            }
        }
    }
}
