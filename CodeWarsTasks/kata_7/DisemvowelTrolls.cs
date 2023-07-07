using System.Linq;

namespace CodeWarsTasks.kata_7
{
    public class DisemvowelTrolls
    {
        public static string Disemvowel(string str)
        {
            string vowels = "aeiouAEIOU";
            return new string(str.Where(c => !vowels.Contains(c)).ToArray());
        }
    }
}