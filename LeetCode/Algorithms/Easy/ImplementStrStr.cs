using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class ImplementStrStr : IQuestion
    {
        private const string question = "Implement StrStr";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            const string needle = "cde";
            const string haystack = "abcdefg";
            Console.WriteLine(solution(haystack, needle));
        }

        private static int solution(string haystack, string needle)
        {
            var m = needle.Length;
            var n = haystack.Length;

            if (n == m && n == 0)
                return 0;

            if (m == 0)
                return 0;

            for (var i = 0; i < n - m + 1; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    if (!haystack[i + j].Equals(needle[j]))
                        break;

                    if (j == m - 1)
                        return i;
                }
            }
            return -1;

        }
    }
}
