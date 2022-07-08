using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPractice.Basic;

namespace CSharpPractice
{
    class Program
    {
        private static void Main(string[] args)
        {
            Medium m = new Medium();

            int n = 120;
            Console.WriteLine("Original number: " + n);
            Console.WriteLine("Next prime number/Current prime number: " + m.test(n));
            n = 321;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Next prime number/Current prime number: " + m.test(n));
            n = 43;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Next prime number/Current prime number: " + m.test(n));
            n = 4433;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Next prime number/Current prime number: " + m.test(n)); ;
        }
    }
}
