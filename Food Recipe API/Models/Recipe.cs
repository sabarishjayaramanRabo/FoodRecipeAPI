using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Recipe_API.Models
{
    public class Recipe
    {
        public string Name { get; set; }

        public CuisineType CuisineType { get; set; }

        public bool IsVeg { get; set; }

        public string Ingredients { get; set; }
    }

    public enum CuisineType
    {
        Italian,
        Japanese,
        Chinese,
        Indian,
        American
    }
}