using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWarsTasks.kata_6
{
    public class CountSmileyFaces
    {
        public static int CountSmileys(string[] smileys)
        {
            if (smileys == null || smileys.Length == 0) return 0;
            
            var regex = new Regex(@"^[;:][-~]?[)D]$");

            return smileys.Count(s => regex.IsMatch(s));
        }
    }
}