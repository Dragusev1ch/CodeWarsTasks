using System;

namespace CodeWarsTasks.kata_7
{
    public class YouAreSquare
    {
        public static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }
    }
}