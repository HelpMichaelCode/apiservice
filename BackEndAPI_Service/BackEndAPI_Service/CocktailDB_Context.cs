using Microsoft.EntityFrameworkCore;

namespace BackEndAPI_Service
{
    public class CocktailDB_Context : DbContext
    {
        public DbSet<Drinks> Drinks { get; set; }

        public CocktailDB_Context() { }
        public CocktailDB_Context(DbContextOptions<CocktailDB_Context> options) : base(options) { }
    }
}
