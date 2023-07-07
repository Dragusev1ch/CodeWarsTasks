using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks.kata_6
{
    internal class SplitStrings
    {
        public static string[] Solution(string str)
        {
            if (str.Length % 2 == 1)
                str += '_';
            string[] array = new string[str.Length / 2];
            for (int i = 0; i < str.Length; i += 2)
                array[i / 2] = str.Substring(i, 2);
            return array;
        }
    }
}
