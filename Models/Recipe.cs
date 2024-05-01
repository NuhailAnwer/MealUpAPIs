using MealUP.Models.Enums;

namespace MealUP.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FoodType Type { get; set; }
        public SweetSavory sweet_savory { get; set; }

        public CookingMethod Cooking_Method { get; set; }

        public List<Quantity> Quantity { get; set; }

        public List<Instruction> Instructions { get; set; } 
    }
}
