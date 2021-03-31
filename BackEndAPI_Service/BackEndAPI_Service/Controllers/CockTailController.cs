using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;

namespace BackEndAPI_Service.Controllers
{
    [ApiController]
    [Route("cocktails")]
    public class CockTailController : Controller
    {
        private readonly DrinksDBContext dBContext = new DrinksDBContext();

        [HttpGet("alldrinks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Drinks> GetAllDrinks()
        {
            var result = dBContext.Drinks.OrderBy(d => d.ID);
            if (result != null)
                return Ok(result);
            else
                return NotFound("No data found!");
        }

        [HttpGet("filter")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Drinks> GetSpecificDrink([FromQuery] string name)
        {
            if (!String.IsNullOrEmpty(name)) 
            {
                var result = dBContext.Drinks.Where(d => d.DrinkName.Contains(name));
                return Ok(result);
            }
            else
                return NotFound("No drinks found!");
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Drinks> AddDrink(Drinks drink)
        {
            if(drink != null)
            {
                dBContext.Add(drink);
                dBContext.SaveChanges();
                return Ok($"New drink added!: \n{drink}");
            }
            else
            {
                return BadRequest("Error adding data!");
            }
        }

        [HttpDelete("ID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Drinks> DeleteDrink([FromQuery] int ID)
        {
            if(ID != null)
            {
                var drinkItem = dBContext.Drinks.Where(d => d.ID == ID);
                var result = dBContext.Drinks.Remove((Drinks)drinkItem);
                dBContext.SaveChanges();
                return Ok("Drink deleted!");
            }
            else
            {
                return BadRequest("Error in deleting drink!");
            }
        }
    }
}
