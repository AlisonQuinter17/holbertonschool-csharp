using System;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            string lower_string = s.ToLower();
            lower_string = Regex.Replace(lower_string, "[:;,. \t\n\r]", "");
            char[] s_reversed = lower_string.ToCharArray();
            Array.Reverse(s_reversed);

            if (s == s_reversed || s == "")
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
}
