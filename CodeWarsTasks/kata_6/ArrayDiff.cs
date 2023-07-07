using System.Linq;

namespace CodeWarsTasks.kata_6
{
    public class ArrayDiff
    {
        public static int[] ArrayDiffMethod(int[] a, int[] b) => a.Where(el => !b.Contains(el)).ToArray();
    }
}