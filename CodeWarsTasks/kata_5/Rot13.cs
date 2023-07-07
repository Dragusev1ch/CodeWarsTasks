using System.Text;
using System;

namespace CodeWarsTasks.kata_5
{
    public class Rot13Class
    {
        public static string Rot13(string message)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                if (Char.IsLetter(message[i]))
                {
                    if ((message[i] > 64 && message[i] < 78) || (message[i] > 96 && message[i] < 110))
                        sb.Append((char)(message[i] + 13));
                    else sb.Append((char)(message[i] - 13));
                }
                else sb.Append(message[i]);
            }
            return sb.ToString();
        }
    }
}