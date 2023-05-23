using System;
using System.Linq;

namespace CodeWarsTasks.kata_6
{
    public class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            var char_positions = text.ToLower().Where(ch => Char.IsLetter(ch)).
                Select(ch => (int)ch % 32).ToArray();
            return string.Join(" ", char_positions);
        }
    }
}