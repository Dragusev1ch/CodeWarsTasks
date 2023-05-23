using System.Linq;

namespace CodeWarsTasks.kata_8
{
    public class AreYouPlayingBanjo
    {
        public static string AreYouPlaying_Banjo(string name)
        {
            if (name.First() == 'R' || name.First() == 'r')
                return name + " plays banjo";
            else
                return name + " does not play banjo";
        }
    }
}