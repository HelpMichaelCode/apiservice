using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndAPI_Service
{
    // Connection class towards the database
    public class DrinksDBContext : DbContext
    {
        // This indicates the Drinks table 
        public DbSet<Drinks> Drinks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DrinksDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public static class DatabaseIntializer
        {
            public static void Init(DrinksDBContext db_context)
            {
                db_context.Database.EnsureCreated();
            }
        }
    }
}
