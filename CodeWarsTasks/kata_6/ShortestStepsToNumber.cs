namespace CodeWarsTasks.kata_6
{
    public class ShortestStepsToNumber
    {
        public static int ShortestStepsToNum(int num)
        {
            if(num <= 1) return 0;
            if(num % 2 == 1) return 1 + ShortestStepsToNum(num - 1);
            return 1 + ShortestStepsToNum(num / 2);
        }
    }
}