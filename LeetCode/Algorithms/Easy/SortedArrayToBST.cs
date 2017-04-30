using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class SortedArrayToBST : IQuestion
    {
        private const string question = "Convert Sorted Array to Binary Search Tree";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            Utility.PrintTreePreOrder(solution(new[] {1, 2, 3, 4, 5, 6, 7}));
            Console.WriteLine();
        }

        private static TreeNode solution (int[] nums)
        {
            return sortedArrayToBST(nums, 0, nums.Length-1);
        }

        private static TreeNode sortedArrayToBST(int[] nums, int start, int end)
        {
            if (start > end)
                return null;

            var mid = start + (end - start) / 2;
            var node = new TreeNode(nums[mid])
            {
                left = sortedArrayToBST(nums, start, mid - 1), 
                right = sortedArrayToBST(nums, mid + 1, end)
            };

            return node;
        }
    }
}
