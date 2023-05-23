using System;

namespace CodeWarsTasks.kata_4
{
    public class NextSmallerNumberWithSameDigits
    {
        public static long NextSmaller(long n)
        {
            char[] chars = n.ToString().ToCharArray();
            int[] ints = new int[chars.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                ints[i] = Digit(chars[i], 10);
            }

            int startingIndex = ints.Length - 1;
            for (int i = ints.Length - 2; i >= 0; i--)
            {
                int max = i == 0 ? 0 : int.MinValue;
                int maxIndex = -1;
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[j] > max && ints[j] < ints[i])
                    {
                        max = ints[j];
                        maxIndex = j;
                    }
                }

                if (maxIndex >= 0)
                {
                    int temp = ints[maxIndex];
                    ints[maxIndex] = ints[i];
                    ints[i] = temp;

                    startingIndex = i;
                    break;
                }
            }

            for (int i = startingIndex + 1; i < ints.Length - 1; i++)
            {
                int max = ints[i];
                int sortIndex = i;
                for (int j = i; j < ints.Length; j++)
                {
                    if (ints[j] > max)
                    {
                        max = ints[j];
                        sortIndex = j;
                    }
                }

                int temp = ints[i];
                ints[i] = max;
                ints[sortIndex] = temp;
            }
            String newNum = "";
            for (int i = 0; i < ints.Length; i++)
            {
                newNum += ints[i];
            }
            long newValue = long.Parse(newNum);
            return newValue == n ? -1 : newValue;
        }
        public static int Digit(char value, int radix)
        {
            if ((radix <= 0) || (radix > 36))
                return -1;

            if (radix <= 10)
                if (value >= '0' && value < '0' + radix)
                    return value - '0';
                else
                    return -1;
            else if (value >= '0' && value <= '9')
                return value - '0';
            else if (value >= 'a' && value < 'a' + radix - 10)
                return value - 'a' + 10;
            else if (value >= 'A' && value < 'A' + radix - 10)
                return value - 'A' + 10;

            return -1;
        }
    }
}