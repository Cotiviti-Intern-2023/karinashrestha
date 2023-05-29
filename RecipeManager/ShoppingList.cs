using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    using System;
    using System.Collections.Generic;

    public class ShoppingList
    {
        private List<string> ingredients;

        public ShoppingList()
        {
            ingredients = new List<string>();
        }

        public void AddIngredients(List<string> newIngredients)
        {
            ingredients.AddRange(newIngredients);
        }

        public void DisplayShoppingList()
        {
            Console.WriteLine("Shopping List:");
            foreach (string ingredient in ingredients)
            {
                Console.WriteLine($"- {ingredient}");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }

}
