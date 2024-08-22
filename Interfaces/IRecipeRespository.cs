using MealUP.Models; 
using MealUP.ModelRequest;
using MealUP.ModelResponse;
using Microsoft.AspNetCore.Mvc;

namespace MealUP.Interfaces
{
    public interface IRecipeRespository
    {

        public List<RecipeResponse> GetAll();



    } 
}