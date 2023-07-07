using System.Linq;
using static System.String;

namespace CodeWarsTasks.kata_6
{
    public class IPValidation
    {
        public static bool is_valid_IP(string ipAddres)
        {
            if (IsNullOrWhiteSpace(ipAddres)) return false;

            var splitValues = ipAddres.Split('.');
            if (splitValues.Length != 4) return false;

            foreach (var t in splitValues)
                if (t.Length >= 2 && t.FirstOrDefault() == '0') return false;

            for (var i = 0; i < ipAddres.Length; i++)
            {
                if (ipAddres[i] == ' ' || ipAddres[i] == '-') return false;
                if (i != 0 && ipAddres[i] == '0' && ipAddres[i - 1] == '0' &&
                    ipAddres[i - 2] != '1' && ipAddres[i - 1] != '2') return false;
            }

            return splitValues.All(r => byte.TryParse(r, out _));
        }
    }
}