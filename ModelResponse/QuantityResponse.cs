using MealUP.Models.Enums;

namespace MealUP.ModelResponse
{
    public class QuantityResponse
    {
        public string Ingredient { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
    }
}
