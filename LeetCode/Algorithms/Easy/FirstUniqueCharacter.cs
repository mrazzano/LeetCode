using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class FirstUniqueCharacter : IQuestion
    {
        private const string question = "First Unique Character in String";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const string s = "loveleetcode";
            Console.WriteLine(solution(s));
        }

        private static int solution(string s)
        {
            var count = new int[26];
            foreach (var letter in s)
            {
                count[letter - 'a']++;
            }

            for (var i = 0; i < s.Length; i++)
            {
                if (count[s[i] - 'a'] == 1)
                    return i;
            }
            return -1;
        }
    }
}
