using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndAPI_Service
{
    public class Drinks
    {
        public string ID { get; set; } // Primary Key
        public string DrinkName { get; set; }
        public int PercentageOfAlcohol { get; set; }
        public int Milliliter { get; set; }
    }
}
