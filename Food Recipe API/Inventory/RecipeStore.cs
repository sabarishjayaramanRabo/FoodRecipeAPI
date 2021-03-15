using Food_Recipe_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Recipe_API
{
    public class RecipeStore
    {
        public List<Recipe> Recipes { get; set; }

        public RecipeStore()
        {
            Recipes = new List<Recipe> {
                new Recipe
                {
                    Name = "Recipe1",
                    IsVeg = false,
                    CuisineType = CuisineType.American,
                    Ingredients = "Ing1,Ing2"
                },
                new Recipe
                {
                    Name = "Recipe2",
                    IsVeg = true,
                    CuisineType = CuisineType.Indian,
                    Ingredients = "Ing3,Ing4"
                }
            };
        }
    }
}