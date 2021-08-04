using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class MaxNumCheck<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;

        //Generic Type extends Comparable

        public MaxNumCheck(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        public T MaximumOf()
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                return firstValue;
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                return secondValue;
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                return thirdValue;
            throw new Exception(" All three values are Equal. ");
        }
    }
}