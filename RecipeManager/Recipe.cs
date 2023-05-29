using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }

        public Recipe(string name, List<string> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }

        public void Display()
        {
            Console.WriteLine($"Recipe: {Name}");
            Console.WriteLine("Ingredients:");
            foreach (string ingredient in Ingredients)
            {
                Console.WriteLine($"- {ingredient}");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }

}

