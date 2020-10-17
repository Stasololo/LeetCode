using LeetCode.Difficulty;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Easy

            #region 1108. Defanging an IP Address
            //https://leetcode.com/problems/defanging-an-ip-address/
            //Example 1:
            //string address = "1.1.1.1";
            //Output: "1[.]1[.]1[.]1"

            //Example 2:
            //string address = "255.100.50.0";
            //Output: "255[.]100[.]50[.]0"

            //var result = Easy.DefangIPaddr(address);
            #endregion

            #region 1512. Number of Good Pairs
            //https://leetcode.com/problems/number-of-good-pairs/
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
            //https://leetcode.com/problems/shuffle-the-array/
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
            //https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
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
            //https://leetcode.com/problems/running-sum-of-1d-array/
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
            //https://leetcode.com/problems/two-sum/
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

            #endregion

            //----------------------------------------------------------------------------//

            #region Medium

            #region 3. Longest Substring Without Repeating Characters
            //https://leetcode.com/problems/longest-substring-without-repeating-characters/
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
            // https://leetcode.com/problems/longest-palindromic-substring/
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
            //https://leetcode.com/problems/string-to-integer-atoi/
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

            #endregion

            //----------------------------------------------------------------------------//

            #region Hard

            #region 4. Median of Two Sorted Arrays
            // https://leetcode.com/problems/median-of-two-sorted-arrays/
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
