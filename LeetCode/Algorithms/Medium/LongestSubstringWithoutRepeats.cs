using System;
using System.Collections.Generic;
using LeetCode.Library;

namespace LeetCode.Algorithms.Medium
{
    public class LongestSubstringWithoutRepeats : IQuestion
    {
        private const string question = "Longest Substring Without Repeating Characters";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const string s = "abcabcbb";
            Console.WriteLine(solution(s));
        }

        private static int solution(string s)
        {
            var start = 0;
            var result = 0;
            var dict = new Dictionary<char, int>();
            for (var i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    start = Math.Max(start, dict[s[i]] + 1);
                    dict[s[i]] = i;
                }
                else
                {
                    dict.Add(s[i], i);
                }

                result = Math.Max(result, i - start + 1);
            }

            return result;
        }
    }
}
