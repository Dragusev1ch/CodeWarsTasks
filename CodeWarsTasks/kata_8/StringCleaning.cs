using System.Linq;

namespace CodeWarsTasks.kata_8
{
    public class StringCleaning
    {
        public static string StringClean(string str) => str.Where(t => !char.IsDigit(t))
            .Aggregate("", (current, t) => current + t);
        
    }
}