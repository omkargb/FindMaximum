using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class MaxNumCheck
    {
        public int IntMax(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
                return num1;
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
                return num2;
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
                return num3;
            return 0;
        }

        public float FloatMax(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
                return num1;
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
                return num2;
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
                return num3;
            return 0;
        }

        public string StringMax(string string1, string string2, string string3)
        {
            if (string1.CompareTo(string2) > 0 && string1.CompareTo(string3) > 0)
                return string1;
            if (string2.CompareTo(string1) > 0 && string2.CompareTo(string3) > 0)
                return string2;
            if (string3.CompareTo(string1) > 0 && string3.CompareTo(string2) > 0)
                return string3;
            return "All are Equal";
        }
    }
}
