using System;
using System.Text.RegularExpressions;

namespace ValidIPAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(ValidIPAddress("01.01.01.01"));
        }

        private static string ValidIPAddress(string IP)
        {
            var ip4 = CheckForIpV4(IP);
            var ip6 = CheckForIpV6(IP);
            if (ip4)
            { return "IPv4"; }
            else if (ip6) { return "IPv6"; }
            else { return "Neither"; }
        }

        private static bool CheckForIpV4(string IP)
        {
            var arr = IP.Split('.');
            if (arr.Length != 4)
            {
                return false;
            }
            foreach (var s in arr)
            {
                if ((s.Length > 1 && s[0] == '0') || !byte.TryParse(s, out byte b))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool CheckForIpV6(string IP)
        {
            var arr = IP.Split(':');
            if (arr.Length != 8)
            {
                return false;
            }
            foreach (var s in arr)
            {
                Match m = Regex.Match(s, "^[A-Fa-f0-9]{1,4}$", RegexOptions.IgnoreCase);
                if (!m.Success)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
