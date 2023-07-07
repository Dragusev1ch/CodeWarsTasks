using System.Linq;

namespace CodeWarsTasks.kata_8
{
    public class CountingSheep
    {
        public static int CountSheeps(bool[] sheeps) => sheeps.Count(t => t);
    }
}