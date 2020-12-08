using LeetCode.Difficulty;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Easy

            #region 1108. Defanging an IP Address
            /// https://leetcode.com/problems/defanging-an-ip-address/

            //Example 1:
            //string address = "1.1.1.1";
            //Output: "1[.]1[.]1[.]1"

            //Example 2:
            //string address = "255.100.50.0";
            //Output: "255[.]100[.]50[.]0"

            //var result = Easy.DefangIPaddr(address);
            #endregion

            #region 1512. Number of Good Pairs
            /// https://leetcode.com/problems/number-of-good-pairs/

            //Example 1:
            //int[] nums = { 1, 2, 3, 1, 1, 3 };
            //Output: 4

            //Example 2:
            //int[] nums = { 1, 1, 1, 1 };
            //Output: 6

            //Example 3:
            //int[] nums = { 1, 2, 3 };
            //Output: 0

            //var result = Easy.NumIdenticalPairs(nums);
            #endregion

            #region 1470. Shuffle the Array
            /// https://leetcode.com/problems/shuffle-the-array/

            //Example 1:
            //int[] nums = { 2, 5, 1, 3, 4, 7 };
            //int n = 3;
            //Output: [2, 3, 5, 4, 1, 7]

            //Example 2:
            //int[] nums = { 1, 2, 3, 4, 4, 3, 2, 1 };
            //int n = 4;
            //Output: [1, 4, 2, 3, 3, 2, 4, 1]

            //Example 3:
            //int[] nums = { 1, 1, 2, 2 };
            //int n = 2;
            //Output: [1, 2, 1, 2]

            //var result = Easy.Shuffle(nums, n);
            #endregion

            #region 1431. Kids With the Greatest Number of Candies 
            /// https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/

            //Example 1:
            //int[] candies = { 2, 3, 5, 1, 3 };
            //int extraCandies = 3;
            //Output: [true, true, true, false, true]

            //Example 2:
            //int[] candies = { 4, 2, 1, 1, 2 };
            //int extraCandies = 1;
            //Output: [true, false, false, false, false]

            //Example 3:
            //int[] candies = { 12, 1, 12 };
            //int extraCandies = 10;
            //Output: [true, false, true]

            //var result = Easy.KidsWithCandies(candies, extraCandies);
            #endregion

            #region 1480. Running Sum of 1d Array
            /// https://leetcode.com/problems/running-sum-of-1d-array/

            //Example 1:
            //int[] nums = { 1, 2, 3, 4 };
            //Output: [1,3,6,10]

            //Example 2:
            //int[] nums = { 1, 1, 1, 1, 1 };
            //Output: [1, 2, 3, 4, 5]

            //Example 3:
            //int[] nums = {3, 1, 2, 10, 1};
            //Output: [3,4,6,16,17]

            //var result = Easy.RunningSum(nums);
            #endregion

            #region 1. Two Sum 
            /// https://leetcode.com/problems/two-sum/

            //Example 1:
            //int[] nums = { 2, 7, 11, 15 };
            //int target = 9;
            //Output: [0, 1]

            //Example 2:
            //int[] nums = { 3, 2, 4 };
            //int target = 6;
            //Output: [1, 2]

            //Example 3:
            //int[] nums = { 3, 3 };
            //int target = 6;
            //Output: [0, 1]

            //var result = Easy.TwoSum(nums, target);
            #endregion

            #region 9. Palindrome Number
            /// https://leetcode.com/problems/palindrome-number/

            //Example 1:
            //int x = 121;
            //Output: true

            //Example 2:
            //int x = -121;
            //Output: false

            //Example 3:
            //int x = 10;
            //Output: false

            //Example 4:
            //int x = -101;
            //Output: false

            //var result = Easy.IsPalindrome(x);
            #endregion

            ////////////////////////////
            #region 13. Roman to Integer 
            /// https://leetcode.com/problems/roman-to-integer/

            //Example 1:
            //string s = "III";
            //Output: 3

            //Example 2:
            //Input: s = "IV";
            //Output: 4

            //Example 3:
            //string s = "IX";
            //Output: 9

            //Example 4:
            //string s = "LVIII";
            //Output: 58

            //var result = Easy.RomanToInt(s);
            #endregion

            ////////////////////////////
            #region 14. Longest Common Prefix
            /// https://leetcode.com/problems/longest-common-prefix/

            //Example 1:
            //string[] strs = { "flower", "flow", "flight" };
            //Output: "fl"

            //Example 2:
            //string[] strs = {"dog", "racecar", "car"};
            //Output: ""

            //var result = Easy.LongestCommonPrefix(strs);
            #endregion

            #region 1662. Check If Two String Arrays are Equivalent
            /// https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/

            //Example 1:
            //string[] word1 = { "ab", "c" };
            //string[] word2 = { "a", "bc" };
            //Output: true

            //Example 2:
            //string[] word1 = { "a", "cb" };
            //string[] word2 = { "ab", "c" };
            //Output: false

            //Example 3:
            //string[] word1 = {"abc", "d", "defg"};
            //string[] word2 = {"abcddefg"};
            //Output: true

            //var result = Easy.ArrayStringsAreEqual(word1, word2);
            #endregion

            #region 1486. XOR Operation in an Array
            /// https://leetcode.com/problems/xor-operation-in-an-array/

            //Example 1:
            //int n = 5;
            //int start = 0;
            //Output: 8

            //Example 2:
            //int n = 4;
            //int start = 3;
            //Output: 8

            //Example 3:
            //int n = 1;
            //int start = 7;
            //Output: 7

            //Example 4:
            //int n = 10;
            //int start = 5;
            //Output: 2

            //var result = Easy.XorOperation(n, start);
            #endregion

            #region 1281. Subtract the Product and Sum of Digits of an Integer
            /// https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/

            //Example 1:
            //int n = 234;
            //Output: 15

            //Example 2:
            //int n = 4421;
            //Output: 21

            //var result = Easy.SubtractProductAndSum(n);
            #endregion

            #region 1365. How Many Numbers Are Smaller Than the Current Number
            /// https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/

            //Example 1:
            //int[] nums = { 8, 1, 2, 2, 3 };
            //Output: [4, 0, 1, 1, 3]

            //Example 2:
            //int[] nums = { 6, 5, 4, 8 };
            //Output: [2, 1, 0, 3]

            //Example 3:
            //int[] nums = { 7, 7, 7, 7 };
            //Output: [0, 0, 0, 0]

            //var result = Easy.SmallerNumbersThanCurrent(nums);
            #endregion

            ////////////////////////////
            #region 1534. Count Good Triplets
            /// https://leetcode.com/problems/count-good-triplets/

            //Example 1:
            //int[] arr = { 3, 0, 1, 1, 9, 7 };
            //int a = 7;
            //int b = 2;
            //int c = 3;
            //Output: 4

            //Example 2:
            //int[] arr = { 1, 1, 2, 2, 3 };
            //int a = 0;
            //int b = 0;
            //int c = 1;
            //Output: 0

            //var result = Easy.CountGoodTriplets(arr, a, b, c);
            #endregion

            #region 1295. Find Numbers with Even Number of Digits
            /// https://leetcode.com/problems/find-numbers-with-even-number-of-digits/
            //Example 1:
            //int[] nums = { 12, 345, 2, 6, 7896 };
            //Output: 2

            //Example 2:
            //int[] nums = { 555, 901, 482, 1771 };
            //Output: 1

            //var result = Easy.FindNumbers(nums);
            #endregion

            #region 1678. Goal Parser Interpretation
            /// https://leetcode.com/problems/goal-parser-interpretation/

            //Example 1:
            //string command = "G()(al)";
            //Output: "Goal"

            //Example 2:
            //string command = "G()()()()(al)";
            //Output: "Gooooal"

            //Example 3:
            //string command = "(al)G(al)()()G";
            //Output: "alGalooG"

            //var result = Easy.Interpret(command);
            #endregion

            #region 1672. Richest Customer Wealth
            /// https://leetcode.com/problems/richest-customer-wealth/

            //Example 1:
            //int[][] accounts = { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } };
            //Output: 6

            //Example 2:
            //int[][] accounts = { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 } };
            //Output: 10

            //Example 3:
            //int[][] accounts = { new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 } };
            //Output: 17

            //var result = Easy.MaximumWealth(accounts);
            #endregion

            #region 771. Jewels and Stones
            /// https://leetcode.com/problems/jewels-and-stones/

            //Example 1:
            //string J = "aA";
            //string S = "aAAbbbb";
            //Output: 3

            //Example 2:
            //string J = "z";
            //string S = "ZZ";
            //Output: 0

            //var result = Easy.NumJewelsInStones(J, S);
            #endregion

            #region 1342. Number of Steps to Reduce a Number to Zero
            /// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/

            //Example 1:
            //int num = 14;
            //Output: 6

            //Example 2:
            //int num = 8;
            //Output: 4

            //Example 3:
            //int num = 123;
            //Output: 12

            //var result = Easy.NumberOfSteps(num);
            #endregion

            #region 1389. Create Target Array in the Given Order
            /// https://leetcode.com/problems/create-target-array-in-the-given-order/

            //Example 1:
            int[] nums = { 0, 1, 2, 3, 4 };
            int[] index = { 0, 1, 2, 2, 1 };
            //Output: [0, 4, 1, 3, 2]

            //Example 2:
            //int[] nums = { 1, 2, 3, 4, 0 };
            //int[] index = { 0, 1, 2, 3, 0 };
            //Output: [0, 1, 2, 3, 4]

            //Example 3:
            //int[] nums = { 1 };
            //int[] index = { 0 };
            //Output: [1]

            var result = Easy.CreateTargetArray(nums, index);
            #endregion

            #endregion

            //----------------------------------------------------------------------------//

            #region Medium

            #region 3. Longest Substring Without Repeating Characters
            /// https://leetcode.com/problems/longest-substring-without-repeating-characters/

            //Example 1:
            //string s = "abcabcbb";
            //Output: 3

            //Example 2:
            //string s = "bbbbb";
            //Output: 1

            //Example 3:
            //string s = "pwwkew";
            //Output: 3

            //Example 4:
            //string s = "";
            //Output: 0

            //var result = Medium.LengthOfLongestSubstring(s);
            #endregion

            #region 5. Longest Palindromic Substring
            /// https://leetcode.com/problems/longest-palindromic-substring/

            //Example 1:
            //string s = "babad";
            //Output: "bab" || "aba"

            //Example 2:
            //string s = "cbbd";
            //Output: "bb"

            //Example 3:
            //string s = "a";
            //Output: "a"

            //Example 4:
            //string s = "ac";
            //Output: "a"

            //var result = Medium.LongestPalindrome(s);
            #endregion

            #region 8. String to Integer (atoi)
            /// https://leetcode.com/problems/string-to-integer-atoi/

            //Example 1:
            //string str = "42";
            //Output: 42

            //Example 2:
            //string str = "   -42";
            //Output: -42

            //Example 3:
            //string str = "4193 with words";
            //Output: 4193

            //Example 4:
            //string str = "words and 987";
            //Output: 0

            //Example 5:
            //string str = "-91283472332";
            //Output: -2147483648

            //var result = Medium.MyAtoi(str);
            #endregion

            #region 12. Integer to Roman
            /// https://leetcode.com/problems/integer-to-roman/

            //Example 1:
            //int num = 3;
            //Output: "III"

            //Example 2:
            //int num = 4;
            //Output: "IV"

            //Example 3:
            //int num = 9;
            //Output: "IX"

            //Example 4:
            //int num = 58;
            //Output: "LVIII"

            //Example 5:
            //int num = 1994;
            //Output: "MCMXCIV"

            //var result = Medium.IntToRoman(num);
            #endregion

            #endregion

            //----------------------------------------------------------------------------//

            #region Hard

            #region 4. Median of Two Sorted Arrays
            /// https://leetcode.com/problems/median-of-two-sorted-arrays/

            //Example 1:
            //int[] nums1 = { 1, 3 };
            //int[] nums2 = { 2 };
            //Output: 2.00000

            //Example 2:
            //int[] nums1 = { 1, 2 };
            //int[] nums2 = { 3, 4 };
            //Output: 2.50000

            //Example 3:
            //int[] nums1 = { 0, 0 };
            //int[] nums2 = { 0, 0 };
            //Output: 0.00000

            //Example 4:
            //int[] nums1 = { };
            //int[] nums2 = { 1 };
            //Output: 1.00000

            //Example 5:
            //int[] nums1 = { 2 };
            //int[] nums2 = { };
            //Output: 2.00000

            //var result = Hard.FindMedianSortedArrays(nums1, nums2);
            #endregion

            #endregion

        }
    }
}
