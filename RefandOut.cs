using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Value Types by Reference
namespace ValueVsReference
{
    internal class RefandOut
    {
        static void main(string[] args)
        {
            
            int num1 = 5;
            int num2 = 3;

            Console.WriteLine("Values before swapping:{0} {1}", num1, num2);
            //swapping value
           /* int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Values before swapping:{0} {1}", num1, num2);
            Console.ReadKey(); */

            Swap(ref num1, ref num2);
            Console.WriteLine("Values before swapping:{0} {1}", num1, num2);
            Console.ReadKey();

        }
        static void Swap(ref int x , ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }

}

