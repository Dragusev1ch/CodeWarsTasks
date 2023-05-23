namespace CodeWarsTasks.kata_6
{
    public class Multiples_of_3_or_5
    {
        public static int Solution(int value)
        {
            var count = 0;
            for (int i = 1; i < value; i++)
                if (i % 3 == 0 || i % 5 == 0) count += i;
            return count;
        }
    }
}