using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Difficulty
{
    public class Hard
    {

        /// <summary>
        /// 4. Median of Two Sorted Arrays
        /// https://leetcode.com/problems/median-of-two-sorted-arrays/
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double result = 0.0;

            int lenthArrays = nums1.Length + nums2.Length;
            int[] sortedArrays = nums1.Concat(nums2).OrderBy(x => x).ToArray();

            if (lenthArrays % 2 == 1)
            {
                int median = (lenthArrays / 2);
                result = sortedArrays[median];
            }
            else
            {
                int median = (lenthArrays / 2);
                result = (Convert.ToDouble(sortedArrays[median - 1]) + Convert.ToDouble(sortedArrays[median])) / 2.0;
            }

            return result;
        }




       
    }
}
