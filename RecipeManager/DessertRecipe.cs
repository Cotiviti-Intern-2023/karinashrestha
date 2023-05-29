using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class DessertRecipe : Recipe
    {
        public int PreparationTime { get; set; }

        public DessertRecipe(string name, List<string> ingredients, int preparationTime)
            : base(name, ingredients)
        {
            PreparationTime = preparationTime;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Preparation time: {PreparationTime} minutes");
            Console.WriteLine();
            Console.ReadLine();
        }
    }

}
