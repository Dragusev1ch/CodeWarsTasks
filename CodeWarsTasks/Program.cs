using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWarsTasks
{
    public static class Program
    {
        public static int CountSmileys(string[] smileys)
        {
            if(smileys == null  ||  smileys.Length == 0) return 0;

            const string pattern = @"^[;:][-~]?[)D]$";
            var regex = new Regex(pattern);

            return smileys.Count(s => regex.IsMatch(s));
        }

        public static void Main(string[] args)
        {
        }
    }
}