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







    }
}
