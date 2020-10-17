using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Difficulty
{
    public class Medium
    {
        /// <summary>
        /// 3. Longest Substring Without Repeating Characters
        /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            int result = 0;

            return result;
        }

        /// <summary>
        /// 5. Longest Palindromic Substring
        /// https://leetcode.com/problems/longest-palindromic-substring/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string LongestPalindrome(string s)
        {
            string result = String.Empty;

            foreach (var item in s)
            {
                var ch = s.IndexOf(item);

             }

            

            return result;
        }

        /// <summary>
        /// 8. String to Integer (atoi)
        /// </summary>https://leetcode.com/problems/string-to-integer-atoi/
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MyAtoi(string s)
        {
            s = s.Trim();
            char[] strResult = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] == '-' || s[i] == '+') && i == 0)
                {
                    strResult[i] = s[i];
                }
                else if (s[i] == ' ')
                {
                    break;
                }
                else if (Char.IsDigit(s[i]))
                {
                    strResult[i] = s[i];
                }
                else
                {
                    break;
                }
            }

            try
            {
                return Convert.ToInt32(new string(strResult));
            }
            catch (OverflowException)
            {
                if (s.Contains('-'))
                {
                    return int.MinValue;
                }
                else
                {
                    return int.MaxValue;
                }
            }
            catch (FormatException)
            {
                return 0;
            }
        }



    }
}
