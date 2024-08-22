using MealUP.ModelRequest;
using MealUP.Models;

namespace MealUp.Interfaces
{
    public interface IInstructionInterface
    {

        bool Add(int id);

        bool Update(Recipe recipe);

        bool Delete(Recipe recipe);

        bool Save();
    }
}
