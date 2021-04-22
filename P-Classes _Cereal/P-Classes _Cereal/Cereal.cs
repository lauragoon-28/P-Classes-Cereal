using System;
using System.Collections.Generic;
using System.Text;

namespace P_Classes__Cereal
{
    class Cereal
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Calories { get; set; }

        public double Cups { get; set; }

        public Cereal()
        {
            Manufacturer = "";
            Name = "";
            Calories = 0;
            Cups = 0;
        }

    }
}
