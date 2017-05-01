using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class MaximumDepthBinaryTree : IQuestion
    {
        private const string question = "Maximum Depth of Binary Tree";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var root = Utility.GetBinaryTree(new[] { 1, 2, 2, 3, 4, 4, 3 }, 1);
            Console.WriteLine(solution(root));
        }

        private static int solution(TreeNode root)
        {
            if (root == null)
                return 0;

            var lDepth = solution(root.left);
            var rDepth = solution(root.right);

            var result = lDepth > rDepth ? lDepth : rDepth;
            return result + 1;
        }
    }
}
