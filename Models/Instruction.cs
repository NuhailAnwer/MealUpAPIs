using Microsoft.AspNetCore.Mvc.Formatters;

namespace MealUP.Models
{
    public class Instruction
    {
        public int ID { get; set; }
        public int StepNo { get; set; }
        public string Description { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
