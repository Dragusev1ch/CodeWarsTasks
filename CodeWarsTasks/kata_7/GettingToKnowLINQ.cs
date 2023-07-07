using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks.kata_7
{
    internal class GettingToKnowLINQ
    {
        public static int Sum(int[] integers)
        {
            return integers.Sum();
        }

        public static int CountChar(char[] chars, char charToCount)
        {
            return chars.Count(c => c == charToCount);
        }

        public static int[] CalculateSquares(int start, int end)
        {
            return Enumerable.Range(start, end - start + 1).Select(el => (int)Math.Pow(el, 2)).ToArray();
        }
    }
}
