namespace CodeWarsTasks.kata_6
{
    public class RomanNumeralsEncoder
    {
        public static string Solution(int n)
        {
            int[] arabic = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            var result = "";
            var fl = false;
            var count = 0;

            for (var i = 0; i < arabic.Length; i++)
                if (n + 1 == arabic[i])
                {
                    fl = true;
                    result = "I" + roman[i];
                }
            if (!fl)
            {
                for (var i = 0; i < arabic.Length; i++)
                    if (arabic[i] == n)
                    {
                        fl = true;
                        result = roman[i];
                    }
            }
            if (!fl)
            {
                for (var i = 0; i < arabic.Length; i++)
                {
                    for (var j = i + 1; j < arabic.Length; j++)
                    {
                        if ((n == arabic[i] - arabic[j]) && (((arabic[i] - arabic[j]) % 10 == 0) && (arabic[i] - arabic[j]) % 5 == 0))
                        {
                            result = roman[j] + roman[i];
                            fl = true;
                        }
                        if (fl) break;
                    }
                    if (fl) break;
                }
            }
            if (!fl)
            {
                while (n > 0)
                {
                    if (arabic[count] <= n)
                    {
                        n = n - arabic[count];
                        result += roman[count];
                    }
                    else count++;
                }
            }

            return result;
        }
    }
}