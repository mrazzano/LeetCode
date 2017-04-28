using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class MergeSortedArrays : IQuestion
    {
        private const string question = "Merge Sorted Arrays";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            const int m = 3;
            const int n = 3;
            var nums1 = new[] { 1, 4, 6, -1, -1, -1 };
            var nums2 = new[] { 2, 3, 5 };

            solution(nums1, m, nums2, n);
            Utility.PrintArray(nums1);
        }

        private static void solution(int[] nums1, int m, int[] nums2, int n)
        {
            var i = m - 1;
            var j = n - 1;
            var k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                nums1[k--] = nums1[i] > nums2[j] ? nums1[i--] : nums2[j--];
            }

            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}
