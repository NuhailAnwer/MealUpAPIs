using MealUP.Models.Enums;
using MealUP.Models;
using System.ComponentModel.DataAnnotations;

namespace MealUP.ModelRequest
{
    public class RecipeRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 5)]
        public FoodType Type { get; set; }

        [Required]
        [Range(1, 2)]
        public SweetSavory sweet_savory { get; set; }
        [Range(1, 14)]
        [Required]
        public CookingMethod Cooking_Method { get; set; }

        [Required]
        public List<int>  StepNo { get; set; }
        [Required]
        public List<string> Description { get; set; }

        [Required]
        public List<string>  IngredientsName { get; set; }
        [Required]
        public List<int> quantityValue { get; set; }

        [Required]
        public List<MeasuringUnits> units { get; set; }






    }
}
