using MealUP.Models.Enums;
using MealUP.Models;
using System.ComponentModel.DataAnnotations;

namespace MealUP.ModelRequest
{
    public class RecipeRequest
    {
       
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
        public Dictionary<int, string> Instructions { get; set; }


        [Required]
        public List<QuantityResquest> QuntityIngredients { get; set; }





    }
}
