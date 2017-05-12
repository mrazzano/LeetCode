using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class LongestCommonPrefix : IQuestion
    {
        private const string question = "Longest Common Prefix";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var input = new[] { "abc", "abcd" };
            Console.WriteLine(solution(input));
        }

        private static string solution(string[] strs)
        {
            if (strs.Length == 0)
                return "";

            var result = strs[0];
            for (var i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(result, StringComparison.Ordinal) != 0)
                {
                    result = result.Substring(0, result.Length - 1);
                }
            }
            return result;
        }
    }
}
