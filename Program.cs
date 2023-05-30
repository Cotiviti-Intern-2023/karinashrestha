using System;

namespace ValueVsReference
{
    using System;

    class Program
    {
        static void ModifyValue(int value)
        {
            value = 10; // Modifying the copied value
        }

        static void ModifyReference(ref int value)
        {
            value = 10; // Modifying the original value through the reference
        }

        static void Main(string[] args)
        {
            // Pass by value example
            int a = 5;
            Console.WriteLine("Before modifying (pass by value): " + a);
            ModifyValue(a);
            Console.WriteLine("After modifying (pass by value): " + a);
            Console.WriteLine();

            // Pass by reference example
            int b = 5;
            Console.WriteLine("Before modifying (pass by reference): " + b);
            ModifyReference(ref b);
            Console.WriteLine("After modifying (pass by reference): " + b);

            Console.ReadLine();
        }
    }

}
