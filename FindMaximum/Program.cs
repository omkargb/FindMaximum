using System;

namespace FindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Find maximum of 3 programs using generics ");
            MaxNumCheck check = new MaxNumCheck();
            check.IntMax(10, 20, 30);
            check.FloatMax(10.123f, 20.123f, 30.123f);

        }
    }
}
