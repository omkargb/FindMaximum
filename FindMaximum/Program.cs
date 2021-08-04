using System;

namespace FindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Find maximum of 3 programs using generics ");

            MaxNumCheck<int> checkInt = new MaxNumCheck<int>(10, 20, 30);
            checkInt.MaximumOf();

            MaxNumCheck<float> checkFloat = new MaxNumCheck<float>(10.123f, 20.123f, 30.123f);
            checkFloat.MaximumOf();

            MaxNumCheck<string> checkString = new MaxNumCheck<string>("Apple", "Pear", "Banana");
            checkString.MaximumOf();

        }
    }
}
