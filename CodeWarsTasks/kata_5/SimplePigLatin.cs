using System.Linq;

namespace CodeWarsTasks.kata_5
{
    public class SimplePigLatin
    {
        public static string PigIt(string str)
        {
            string temp = "";
            var words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "!")
                {
                    temp = words[i] + words[i].FirstOrDefault() + "ay";
                    words[i] = temp.Remove(0, 1);
                }    
            }
            return string.Join(" ", words);
        }
    }
}