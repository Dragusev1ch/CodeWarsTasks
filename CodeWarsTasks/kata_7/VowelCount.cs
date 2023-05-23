using System.Collections.Generic;

namespace CodeWarsTasks.kata_7
{
    public class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            List<char> chars = new List<char>() { 'a','e','i','o','u'};

            for (int i = 0; i < str.Length; i++)
            for (int j = 0; j < chars.Count; j++)
                if (str[i] == chars[j])
                    vowelCount++;
                else continue;

            return vowelCount;
        }
    }
}