using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Medium
{
    public class LongestPalindromicSubstring : IQuestion
    {
        private const string question = "Longest Palindromic Substring";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const string s = "babad";
            Console.WriteLine(solution(s));
        }

        private static string solution(string s)
        {
            var length = s.Length;
            if (length < 2)
                return s;

            var result = s.Substring(0, 1);
            for (var i = 0; i < length; i++)
            {
                var temp = palindromeHelper(s, i, i);
                if (temp.Length > result.Length)
                    result = temp;

                temp = palindromeHelper(s, i, i + 1);
                if (temp.Length > result.Length)
                    result = temp;
            }
            return result;
        }

        private static string palindromeHelper(string s, int start, int end)
        {
            while (start >= 0 && end < s.Length)
            {
                if (s[start] != s[end])
                    break;

                start--;
                end++;
            }
            return s.Substring(start + 1, end - (start+1));
        }
    }
}
