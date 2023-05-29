using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class ReciepeManager
    {
        private List<Recipe> recipes;

        public ReciepeManager()
        {
            recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public void DisplayAllRecipes()
        {
            foreach (Recipe recipe in recipes)
            {
                recipe.Display();
            }
            Console.ReadLine();
        }
    }

}

