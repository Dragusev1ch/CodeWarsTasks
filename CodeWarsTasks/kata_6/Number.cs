using System.Linq;

namespace CodeWarsTasks.kata_6
{
    public class Number
    {
        public static int DigitalRoot(long n)
        {
            while (n >= 10)
            {
                int sum = 0;
                while (n != 0)
                {
                    sum += (int)(n % 10);
                    n /= 10;
                }

                n = sum;
            }
            return (int)n;
        }
        
    }
}