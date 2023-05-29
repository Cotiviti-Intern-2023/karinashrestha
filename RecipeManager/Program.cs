using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{

    class Program
    {
        static void Main(string[] args)
        {

            Recipe recipe1 = new Recipe("Momo", new List<string> { "flour", "smashed buff", "ginger","tomato sauce", "onion", "garlic" });
            DessertRecipe recipe2 = new DessertRecipe("Chocolate Cake", new List<string> { "flour", "sugar", "cocoa powder", "butter", "eggs" }, 60);
            Recipe recipe3 = new Recipe("Chicken Choila", new List<string> { "chicken", "chilli peppers", "onion", "soy sauce", "garlic" });
            DessertRecipe recipe4 = new DessertRecipe("Apple Pie", new List<string> { "apples", "sugar", "cinnamon", "pie crust" }, 45);


            ReciepeManager manager = new ReciepeManager();
            manager.AddRecipe(recipe1);
            manager.AddRecipe(recipe2);
            manager.AddRecipe(recipe3);
            manager.AddRecipe(recipe4);


            manager.DisplayAllRecipes();


            ShoppingList shoppingList = new ShoppingList();
            shoppingList.AddIngredients(recipe1.Ingredients);

        }
    }
}
  