using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date of birth (dd/mm/yyyy):");

            if (DateTime.TryParse(Console.ReadLine(), out DateTime dateOfBirth))
            {
                if (dateOfBirth > DateTime.Now)
                {
                    Console.WriteLine("Invalid date. It's a future date.");
                }
                else
                {
                    TimeSpan age = DateTime.Now - dateOfBirth;
                    int years = (int)(age.Days / 365);
                    int months = (int)((age.Days % 365) / 30);
                    int days = (int)(age.Days % 30);

                    Console.WriteLine($"You are {age.Days} days old.");
                    Console.WriteLine($"You are {months} month/s old.");
                    Console.WriteLine($"You are {years} year/s old.");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
        }
    }

}
