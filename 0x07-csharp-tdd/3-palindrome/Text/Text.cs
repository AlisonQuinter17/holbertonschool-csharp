using System;

namespace Text
{
    ///<summary> Public class. </summary>
    public class Str
    {
        /// <summary> Max integer. </summary>
        /// <param name="s"> String to reverse. </param>
        /// <returns> True if string is a palindrome, False if it’s not. </returns>
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
