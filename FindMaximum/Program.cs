using System;

namespace FindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find maximum of 3 programs using generics ");
            MaxNumCheck mnc = new MaxNumCheck();
            mnc.IntMax(10, 20, 30);
        }
    }
}
