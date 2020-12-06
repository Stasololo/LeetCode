using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Difficulty
{
    public class Easy
    {
        /// <summary>
        /// 1108. Defanging an IP Address
        /// https://leetcode.com/problems/defanging-an-ip-address/
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static string DefangIPaddr(string address)
        {
            var result = address.Replace(".", "[.]");

            return result;
        }

        /// <summary>
        /// 1512. Number of Good Pairs
        /// https://leetcode.com/problems/number-of-good-pairs/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int NumIdenticalPairs(int[] nums)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i < j)
                    {
                        if (nums[i] == nums[j])
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 1470. Shuffle the Array
        /// https://leetcode.com/problems/shuffle-the-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];
            var resultX = new int[n];
            var resultY = new int[n];

            for (int i = 0; i < resultX.Length; i++)
            {
                resultX[i] = nums[i];
            }
            for (int i = 0; i < resultY.Length; i++, n++)
            {
                resultY[i] = nums[n];
            }
            int j = 0;
            for (int i = 0; i < nums.Length && j < n; i += 2, j++)
            {
                result[i] = resultX[j];
                result[i + 1] = resultY[j];
            }

            return result;
        }

        /// <summary>
        /// 1431. Kids With the Greatest Number of Candies
        /// https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="extraCandies"></param>
        /// <returns></returns>
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new List<bool>();

            var max = candies.OrderByDescending(x => x).FirstOrDefault();

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
            }

            return result;
        }

        /// <summary>
        /// 1480. Running Sum of 1d Array
        /// https://leetcode.com/problems/running-sum-of-1d-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] RunningSum(int[] nums)
        {
            int[] sum = new int[nums.Length];
            sum[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sum[i] = sum[i - 1] + nums[i];
            }

            return sum;
        }

        /// <summary>
        /// 1. Two Sum
        /// https://leetcode.com/problems/two-sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 9. Palindrome Number
        /// https://leetcode.com/problems/palindrome-number/
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            bool result = false;
            var length = x.ToString().Length;
            char[] arr = new char[length];

            for (int i = 0; i < x.ToString().Length && length > 0; i++, length--)
            {
                arr[i] = x.ToString()[length-1];
            }

            var strResult = new string(arr);
            result = strResult.Equals(x.ToString());
            return result;
        }

        /// <summary>
        /// 13. Roman to Integer 
        /// https://leetcode.com/problems/roman-to-integer/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        ////////////////////////////
        public static int RomanToInt(string s)
        {
            int result = 0;



            return result;
        }

        /// <summary>
        /// 14. Longest Common Prefix
        /// https://leetcode.com/problems/longest-common-prefix/
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        ////////////////////////////
        public static string LongestCommonPrefix(string[] strs)
        {
            var result = string.Empty;


            return result;
        }

        /// <summary>
        /// 1662. Check If Two String Arrays are Equivalent
        /// https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            bool result = true;
            var w1 = string.Join("", word1);
            var w2 = string.Join("", word2);

            result = w1.Equals(w2);

            return result;
        }

        /// <summary>
        /// 1486. XOR Operation in an Array
        /// https://leetcode.com/problems/xor-operation-in-an-array/
        /// </summary>
        /// <param name="n"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static int XorOperation(int n, int start)
        {
            int result = 0;
            int[] nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = start + 2 * i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }

            return result;
        }

        /// <summary>
        /// 1281. Subtract the Product and Sum of Digits of an Integer
        /// https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SubtractProductAndSum(int n)
        {
            int result = 0;
            int minuend = 1;
            int subtrahend = 0;
            
            foreach (var item in n.ToString())
            {
                minuend *= Convert.ToInt32(item.ToString());
                subtrahend += Convert.ToInt32(item.ToString());
            }

            result = minuend - subtrahend;

            return result;
        }

        /// <summary>
        /// 1365. How Many Numbers Are Smaller Than the Current Number
        /// https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i && nums[j] < nums[i])
                    {
                        count++;
                    }
                }
                result[i] = count;
            }

            return result;
        }

        /// <summary>
        /// 1534. Count Good Triplets
        /// https://leetcode.com/problems/count-good-triplets/
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        ////////////////////////////
        public static int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int result = 0;
           
            return result;
        }

        /// <summary>
        /// 1295. Find Numbers with Even Number of Digits
        /// https://leetcode.com/problems/find-numbers-with-even-number-of-digits/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindNumbers(int[] nums)
        {
            int result = 0;

            foreach (var item in nums)
            {
                if (item.ToString().Length % 2 == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
