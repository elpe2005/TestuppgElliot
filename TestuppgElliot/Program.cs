using System;
using System.Diagnostics;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in två heltal");
            Console.WriteLine($"{AREA(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()))}");
        }
        static int AREA(int tal1,int tal2)
        {
            int A = tal1 * tal2;
            return A;
        }
    }
}