namespace CodeWarsTasks.kata_7
{
    public class StringEndsWith
    {
        public static bool Solution(string str, string ending) 
        {
            if(ending.Length > str.Length) 
                return false;
        
            var strIndex = str.Length - 1;
            var endingIndex = ending.Length - 1;
        
            while(endingIndex >= 0)
            {
                var strchar = str[strIndex];
                var endingChar = ending[endingIndex];

                if(strchar != endingChar) return false;

                endingIndex--;
                strIndex--;
            }
            return true;
        }
    }
}