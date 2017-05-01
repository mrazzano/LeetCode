using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class SymmetricTree : IQuestion
    {
        private const string question = "Symmetric Tree";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var root = Utility.GetBinaryTree(new[] { 1, 2, 2, 3, 4, 4, 3 }, 1);
            Console.WriteLine(solution(root));
        }

        private static bool solution(TreeNode root)
        {
            if (root == null)
                return true;

            return isSymmetric(root.left, root.right);
        }

        private static bool isSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
                return left == right;

            if (left.val != right.val)
                return false;

            return isSymmetric(left.left, right.right) && isSymmetric(left.right, right.left);
        }
    }
}
