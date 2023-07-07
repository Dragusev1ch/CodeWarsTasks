using System.Collections.Generic;

namespace CodeWarsTasks.kata_6
{
    public class UniqueInOrderClass
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            List<T> result = new List<T>();
            T currentLetter = default(T);
            foreach (var letter in iterable)
            {
                if (!letter.Equals(currentLetter))
                    result.Add(letter);
                currentLetter = letter;
            }
            return result;
        }
    }
}