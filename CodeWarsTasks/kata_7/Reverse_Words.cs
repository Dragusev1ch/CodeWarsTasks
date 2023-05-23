using System;
using System.Linq;

namespace CodeWarsTasks.kata_7
{
    public class Reverse_Words
    {
        public static string ReverseWords(string str)
        {
            return string.Join(" ", str.Split(' ').Select(x => new String(x.Reverse().ToArray())));
        }
    }
}