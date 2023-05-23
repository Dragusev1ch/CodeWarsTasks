using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTasks.kata_6
{
    public class DoesMyNumberLookBigInThis
    {
        public static bool Narcissistic(int value)
        {
            var digits = GetDigits(value);
            return digits.Select(digit => Math.Pow(digit,digits.Count())).Sum() == value;
        }
        private static IEnumerable<int> GetDigits(int value)
        {
            while(value > 0)
            {
                int digit = (int)value % 10;
                value /= 10;
                yield return digit;
            }
        }
    }
}