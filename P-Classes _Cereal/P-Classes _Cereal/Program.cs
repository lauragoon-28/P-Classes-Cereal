using System;
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

            double cups = Convert.ToDouble(productInfo[3]);

            if (cups >= 1)
            {
                Console.WriteLine(productInfo);
            }



        }
    }
}
