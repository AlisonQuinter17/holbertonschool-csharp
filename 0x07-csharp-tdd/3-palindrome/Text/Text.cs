using System;
using System.Text.RegularExpressions;

namespace Text
{
    ///<summary>method verified palindrome</summary>
    public class Str
    {
        /// <summary>Max integer</summary>
        /// <param name="s">string</param>
        /// <returns>True if string is a palindrome, False if it’s not</returns>

        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            s = Regex.Replace(s, "[:;,. \t\n\r]", "");
            char[] s_reversed = s.ToCharArray();
            Array.Reverse(s_reversed);

            for (int compare = 0; compare < s.Length; compare++)
            {
                if (s[compare] != s_reversed[compare])
                {
                    return (false);
                }
            }
            return (true);
        }
    }
}