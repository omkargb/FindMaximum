using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class MaxNumCheck
    {
        //Generic Type extends Comparable
        public T MaximumOf<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                return firstValue;
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                return secondValue;
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                return thirdValue;
            throw new Exception(" 3 values are Equal");
        }


    }
}
