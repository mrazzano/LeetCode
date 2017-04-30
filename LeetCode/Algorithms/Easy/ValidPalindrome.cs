using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class ValidPalindrome : IQuestion
    {
        private const string question = "Valid Palindrome";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const string s = "A man, a plan, a canal: Panama";
            Console.WriteLine(solution(s));
        }

        private static bool solution(string s)
        {
            s = s.ToLower();

            var head = 0;
            var tail = s.Length - 1;
            while (head <= tail)
            {
                if (!Char.IsLetterOrDigit(s[head]))
                {
                    head++;
                }
                else if (!Char.IsLetterOrDigit(s[tail]))
                {
                    tail--;
                }
                else
                {
                    if (s[head] != s[tail])
                        return false;

                    head++;
                    tail--;
                }
            }
            return true;
        }
    }
}
