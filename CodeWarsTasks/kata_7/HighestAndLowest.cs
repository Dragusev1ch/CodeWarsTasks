using System.Linq;
using System;

namespace CodeWarsTasks.kata_7
{
    public class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
        {
            string[] chars = numbers.Split(' ');
            int[] temp_int = Array.ConvertAll(chars, s => int.Parse(s));
            int max = temp_int.Max();
            int min = temp_int.Min();
            return $"{max} {min}";
        }
    }
}