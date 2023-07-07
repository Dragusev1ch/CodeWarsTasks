namespace CodeWarsTasks.kata_6
{
    public class ConvertStringToCamelCase
    {
        public static string ToCamelCase(string str)
        {
            var result = str.Split('-', '_');
            for (int i = 0; i < result.Length; i++)
            {
                if (i != 0)
                    result[i] = result[i].Substring(0, 1).ToUpper() + (result[i].Length > 1 ? result[i].Substring(1) : "");
            }

            return string.Join("", result);
        }
    }
}