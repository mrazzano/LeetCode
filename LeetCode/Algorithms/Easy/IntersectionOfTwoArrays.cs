using System;
using System.Collections.Generic;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class IntersectionOfTwoArrays : IQuestion
    {
        private const string question = "Intersection of Two Arrays";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var nums1 = new[] { 1, 2, 2, 1 };
            var nums2 = new[] { 2, 2 };

            Utility.PrintArray(solution(nums1, nums2));
        }

        private static int[] solution(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            var pntr1 = 0;
            var pntr2 = 0;

            var result = new List<int>();
            while (pntr1 < nums1.Length && pntr2 < nums2.Length)
            {
                if (nums1[pntr1] < nums2[pntr2])
                {
                    pntr1++;
                }
                else
                {
                    if (nums1[pntr1] > nums2[pntr2])
                    {
                        pntr2++;
                    }
                    else
                    {
                        result.Add(nums1[pntr1]);
                        pntr1++;
                        pntr2++;
                    }
                }
            }
            return result.ToArray();
        }
    }
}
