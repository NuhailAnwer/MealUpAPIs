using MealUP.Data;
using MealUp.Interfaces;
using MealUP.ModelRequest;
using MealUP.Models;
using MealUP.Repository;
using Microsoft.AspNetCore.Mvc;
using MealUP.Interfaces;
using MealUP.ModelResponse;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;

namespace MealUP.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class RecipeController : Controller
    {
        MealUpContext mealUpContext;
        public RecipeController(MealUpContext mealUpContext)
        {
            this.mealUpContext = mealUpContext;
        }

        [HttpGet]

        public List<RecipeResponse> GetAll()
        {
            return mealUpContext.Recipes.Select(a =>
            new RecipeResponse
            {
                Id = a.Id,
                Name = a.Name,
                Cooking_Method = a.Cooking_Method.ToString()

            }
            ).ToList();
        }

        [HttpPost]
        public ActionResult<RecipeResponse> PostRecipe(RecipeRequest recipe)
        {
            var rec = new Recipe
            {
                Name = recipe.Name,
                Cooking_Method = recipe.Cooking_Method,
                Type = recipe.Type,
                sweet_savory = recipe.sweet_savory
            };

            mealUpContext.Recipes.Add(rec);
            mealUpContext.SaveChanges();

           
                instructionAdd(rec.Id, recipe);
                PostQuantity(rec.Id, recipe);
                return Ok(rec);

        }

        void instructionAdd(int Id, RecipeRequest recipe)
        {
            foreach (KeyValuePair<int, string> item in recipe.Instructions)
            {

                var ins = new Instruction
                {
                    RecipeId = Id,
                    StepNo = item.Key,
                    Description = item.Value
                };
                mealUpContext.Instructions.Add(ins);                        
            }
            mealUpContext.SaveChanges();
        }
        
       [HttpGet("Ingredients")]
       public List<IngredientResponse> GetIngredients(int  PageNumber,int CountPerPage,string SearchKeyWord)
       {
              var query = mealUpContext.Ingredients.AsQueryable();

            if (!string.IsNullOrEmpty(SearchKeyWord))
            {
                query = query.Where(ing => ing.Name.ToLower().Contains(SearchKeyWord.ToLower()));
            }

            var result = query.Select(ingredient =>
                new IngredientResponse
                {
                    Name = ingredient.Name
                })
                .Skip((PageNumber - 1) * CountPerPage)
                .Take(CountPerPage)
                .ToList();

            return result;
                }

       void PostQuantity(int id,RecipeRequest recipe)

       {
            foreach (var item in recipe.QuntityIngredients)
            {
                var quan = new Quantity
                {
                    RecipeId=id,
                    IngredientId = item.IngredientId,
                    ScaleType = item.Unit,
                    Value=item.Quantity
                 
                };
                mealUpContext.Quantities.Add(quan);
            }
            mealUpContext.SaveChanges();
       }


    }
}
