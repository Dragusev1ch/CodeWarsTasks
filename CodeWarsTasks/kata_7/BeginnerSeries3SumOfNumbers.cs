using System;

namespace CodeWarsTasks.kata_7
{
    public class BeginnerSeries3SumOfNumbers
    {
        public int GetSum(int a, int b)
        {
            var max = Math.Max(a, b);
            var min = Math.Min(a, b);
            return (max - min + 1) * (max + min) / 2;
        }
    }
}