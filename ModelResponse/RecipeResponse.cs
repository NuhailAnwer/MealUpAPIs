using MealUP.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MealUP.ModelResponse
{
    public class RecipeResponse
    {


        public int Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public string sweet_savory { get; set; }
        public string Cooking_Method { get; set; }
      
        public Dictionary<int,string> Instructions { get; set; }
        public List<string> IngredientsName { get; set; }
        public List<int> quantityValue { get; set; }
        public List<string> units { get; set; }






    }
}
