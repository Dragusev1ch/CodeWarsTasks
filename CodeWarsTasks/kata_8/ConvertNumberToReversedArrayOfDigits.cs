using System.Linq;

namespace CodeWarsTasks.kata_8
{
    public class ConvertNumberToReversedArrayOfDigits
    {
            public static long[] Digitize(long n)
            {
                return n.ToString().Reverse().Select(x => long.Parse(x.ToString())).ToArray();
            }
    }
}