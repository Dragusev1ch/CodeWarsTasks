namespace CodeWarsTasks.kata_6
{
    public class TakeTenMinutesWalk
    {
        public static bool IsValidWalk(string[] walk)
        {
            if(walk.Length != 10)
                return false;
            string point = "";
            for (int i = 0; i < walk.Length; i++)
            {
                if (point == walk[i])
                    return false;
                point = walk[i];
            }
            return true;
        }
    }
}