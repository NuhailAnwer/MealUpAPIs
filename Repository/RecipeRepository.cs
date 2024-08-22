using MealUP.Data;
using MealUP.Interfaces;
using MealUP.Models;
using Microsoft.EntityFrameworkCore;
using MealUP.ModelRequest;
using MealUP.ModelResponse;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

namespace MealUP.Repository
{
    public class RecipeRepository : IRecipeRespository
    {
        MealUpContext MealUpContext;
        public RecipeRepository(MealUpContext MealUpContext)
        {
            this.MealUpContext = MealUpContext;
        }

        public List<RecipeResponse> GetAll()
        {
           return MealUpContext.Recipes
                .Select(a => new RecipeResponse
                {
                    Id = a.Id,
                    Name = a.Name,
                    Cooking_Method = a.Cooking_Method.ToString(),
                    sweet_savory = a.sweet_savory.ToString()
                })
                .ToList();

            
        }


    }
}
