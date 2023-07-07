using System;
using System.Linq;

namespace CodeWarsTasks.kata_6
{
    public class DetectPangram
    {
        public static bool IsPangram(string str) => str.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
    }
}