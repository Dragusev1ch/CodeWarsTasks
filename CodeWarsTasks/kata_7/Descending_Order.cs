using System;

namespace CodeWarsTasks.kata_7
{
    public class Descending_Order
    {
        public static int DescendingOrder(int num)
        {
            char[] arr = num.ToString().ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            return Convert.ToInt32(new string(arr));
        }
    }
}