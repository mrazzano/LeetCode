using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class LongestCommonPrefix : IQuestion
    {
        private const string question = "Longest Common Prefix";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var input = new[] { "abc", "abcd" };
            Console.WriteLine(solution(input));
        }

        private static string solution(string[] input)
        {
            var result = "";
            if (input.Length == 0)
                return result;

            var firstString = input[0];
            if (input.Length == 1)
                return firstString;

            for (var i = 0; i < firstString.Length; i++)
            {
                for (var j = 1; j < input.Length; j++)
                {
                    if (firstString[i] != input[j][i])
                        return result;
                }
                result += firstString[i];
            }
            return result;
        }
    }
}
