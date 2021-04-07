using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Microsoft.AspNetCore.Http;

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

        [HttpPost("add")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Drinks> AddDrink(Drinks drink)
        {
            if(drink != null)
            {
                dBContext.Add(drink);
                dBContext.SaveChanges();
                return Ok($"New drink added!");
            }
            else
            {
                return BadRequest("Error adding data!");
            }
        }

        [HttpDelete()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Drinks> DeleteDrink([FromQuery] int ID)
        {
            var drinksDetail = dBContext.Drinks.Find(ID);
            if(drinksDetail != null) 
            {
                dBContext.Remove(drinksDetail);
                dBContext.SaveChanges();
                return Ok("Drink deleted!");
            }
            else
            {
                return BadRequest("Error in deleting drink!");
            }
        }

        [HttpPut("update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Drinks> UpdateDrink(Drinks drink)
        {   
            if (drink != null)
            {
                var drinkToUpdate = dBContext.Drinks.Find(drink.ID);
                if(drinkToUpdate != null)
                {
                    drinkToUpdate.Milliliter = drink.Milliliter;
                    drinkToUpdate.PercentageOfAlcohol = drink.PercentageOfAlcohol;
                    drinkToUpdate.Price = drink.Price;
                    drinkToUpdate.DrinkName = drink.DrinkName;
                    dBContext.SaveChanges();
                }
                return Ok("Drinks Upadted!");
            }
            else
            {
                return BadRequest("Error in updating drinks!");
            }
        }

        [HttpGet("ascending")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Drinks> SortAscending()
        {
            if (dBContext != null)
            {
                return Ok(dBContext.Drinks.OrderBy(d => d.ID));
            }
            else
                return NotFound("Data context not found to be able to connect to DB");
        }

        [HttpGet("descending")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Drinks> SortDescending()
        {
            if (dBContext != null)
            {
                return Ok(dBContext.Drinks.OrderByDescending(d => d.ID));
            }
            else
                return NotFound("Data context not found to be able to connect to DB");
        }
    }
}
