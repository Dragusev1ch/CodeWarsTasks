namespace CodeWarsTasks.kata_8
{
    public class HowGoodAreYouReally
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            int middle = 0;
            int i = 0;
            for (; i < ClassPoints.Length; i++)
            {
                middle += ClassPoints[i];
            }
            return YourPoints > middle / i;
        }
    }
}