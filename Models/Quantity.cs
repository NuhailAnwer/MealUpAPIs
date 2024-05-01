using MealUP.Models.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MealUP.Models
{
    public class Quantity
    {
        public int Id { get; set; }
        public int IngredienntId { get; set; }
        public int RecipeId { get; set; }
        public MeasuringUnits ScaleType { get; set; }
        public int Value { get; set; }
        
        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }

    }
}
