using System.Linq;

namespace CodeWarsTasks.kata_8
{
    public class StairsWillSuzukiClimb
    {
        public static long StairsIn20(int[][] stairs)
        {
            long temp = 0;
            foreach (var t in stairs)
            {
                temp = t.Aggregate(temp, (current, t1) => current + t1 * 20);
            }
            return temp;
        }
    }
}