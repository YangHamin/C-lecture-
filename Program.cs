// See https://aka.ms/new-console-template for more information
using System;

namespace A060_Arraysorting
{
    class Program
    {
        static void Main(string[]args)
        {
            string[] name = { "Mouse", "cow","Tiger","Rabbit" };
            PrintArray("Before sort", name);

            Array.Reverse(name);
            PrintArray("After Reverse", name);

            Array.Sort(name);
            PrintArray("After Sort", name);

            Array.Reverse(name);
            PrintArray("After Reverse", name);

        }
        private static void PrintArray(string s, string[] name)
        {
            Console.WriteLine(s);
            foreach (var n in name) 
            Console.WriteLine("{0}",n);
            Console.WriteLine();    
        }
    }
}
