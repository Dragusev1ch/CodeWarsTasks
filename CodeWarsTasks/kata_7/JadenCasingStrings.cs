using System.Globalization;

namespace CodeWarsTasks.kata_7
{
    public static class JadenCasingStrings
    {
        public static string ToJadenCase(this string phrase)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            return myTI.ToTitleCase(phrase);
        }
    }
}