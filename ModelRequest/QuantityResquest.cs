using MealUP.Models.Enums;

namespace MealUP.ModelRequest
{
    public class QuantityResquest
    {
        public int IngredientId { get; set; }
        public MeasuringUnits Unit { get; set; }
        public int Quantity { get; set; }
    }
}
