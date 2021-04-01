using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndAPI_Service
{
    public class Drinks
    {
        public int ID { get; set; } // Primary Key
        public string DrinkName { get; set; }
        public int PercentageOfAlcohol { get; set; }
        public int Milliliter { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
