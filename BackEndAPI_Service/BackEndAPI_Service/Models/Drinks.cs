using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BackEndAPI_Service
{
    public class Drinks
    {
        [Key]
        public int ID { get; set; } // Primary Key
        [Required]
        public string DrinkName { get; set; }
        [Required]
        public int PercentageOfAlcohol { get; set; }
        [Required]
        public int Milliliter { get; set; }
        [Required]
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
