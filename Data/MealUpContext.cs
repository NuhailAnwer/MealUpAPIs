using Microsoft.EntityFrameworkCore;
using MealUP.Models;

namespace MealUP.Data
{
    public class MealUpContext : DbContext
    {
        public MealUpContext(DbContextOptions<MealUpContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Quantity> Quantities { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
    }
}

