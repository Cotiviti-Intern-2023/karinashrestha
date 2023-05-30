using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ValueVsReference
{
  class MyClass1
   {
       public int Value { get; set; }


       static void ModifyValue(int value)
       {
           value = 10; // Modifying the copied value
       }



       static void ModifyReference(MyClass obj)
       {
           obj.Value = 10; // Modifying the object through the reference
       }



       static void Main(string[] args)
       {
           // Value Type (int)
           int a = 5;
           Console.WriteLine("Value Type (int)");
           Console.WriteLine("Original value: " + a);
           Console.WriteLine("Memory address: " + GetAddress(a));
           Console.WriteLine();



           ModifyValue(a);
           Console.WriteLine("After modifying value:");
           Console.WriteLine("Modified value: " + a);
           Console.WriteLine();



           // Reference Type (class)
           MyClass obj = new MyClass();
           obj.Value = 5;
           Console.WriteLine("Reference Type (class)");
           Console.WriteLine("Original value: " + obj.Value);
           Console.WriteLine("Memory address: " + GetAddress(obj));
           Console.WriteLine();



           ModifyReference(obj);
           Console.WriteLine("After modifying reference:");
           Console.WriteLine("Modified value: " + obj.Value);
       }



       static string GetAddress(object obj)
       {
           return obj.GetHashCode().ToString("X");
       }
   }
}*/

