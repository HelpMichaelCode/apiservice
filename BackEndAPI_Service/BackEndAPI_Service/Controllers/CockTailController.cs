using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace BackEndAPI_Service.Controllers
{
    [ApiController]
    [Route("cocktails")]
    public class CockTailController : Controller
    {
        private readonly CocktailDB_Context _dBContext;
        public CockTailController(CocktailDB_Context cocktaildb)
        {
            _dBContext = cocktaildb;
        }
        [HttpGet("alldrinks")] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Drinks> GetAllDrinks()
        {
            var result = _dBContext.Drinks.OrderBy(d => d.ID);
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
                _dBContext.Add(drink);
                _dBContext.SaveChanges();
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
            var drinksDetail = _dBContext.Drinks.Find(ID);
            if(drinksDetail != null) 
            {
                _dBContext.Remove(drinksDetail);
                _dBContext.SaveChanges();
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
                var drinkToUpdate = _dBContext.Drinks.Find(drink.ID);
                if(drinkToUpdate != null)
                {
                    drinkToUpdate.Milliliter = drink.Milliliter;
                    drinkToUpdate.PercentageOfAlcohol = drink.PercentageOfAlcohol;
                    drinkToUpdate.Price = drink.Price;
                    drinkToUpdate.DrinkName = drink.DrinkName;
                    _dBContext.SaveChanges();
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
            if (_dBContext != null)
            {
                return Ok(_dBContext.Drinks.OrderBy(d => d.DrinkName));
            }
            else
                return NotFound("Data context not found to be able to connect to DB");
        }

        [HttpGet("descending")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Drinks> SortDescending()
        {
            if (_dBContext != null)
            {
                return Ok(_dBContext.Drinks.OrderByDescending(d => d.DrinkName));
            }
            else
                return NotFound("Data context not found to be able to connect to DB");
        }
    }
}
