namespace CodeWarsTasks.kata_6
{
    public class BreakCamelCaseClass
    {
        public static string BreakCamelCase(string str) =>  
            System.Text.RegularExpressions.Regex
                .Replace(str, "([A-Z])", " $1", System.Text.RegularExpressions.RegexOptions.Compiled).Trim();
    }
}