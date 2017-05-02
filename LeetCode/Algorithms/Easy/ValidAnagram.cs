using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class ValidAnagram : IQuestion
    {
        private const string question = "Valid Anagram";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const string s = "anagram";
            const string t = "nagaram";
            Console.WriteLine(solution(s, t));
        }

        private static bool solution(string s, string t)
        {
            var hash = new int[26];
            foreach (var letter in s)
            {
                hash[letter - 'a']++;
            }

            foreach (var letter in t)
            {
                hash[letter - 'a']--;
            }

            foreach (var count in hash)
            {
                if (count != 0)
                    return false;
            }
            return true;
        }

        //private static bool alternateSolution(string s, string t)
        //{
        //    if (s.Length != t.Length)
        //        return false;

        //    var sArray = s.ToCharArray();
        //    var tArray = t.ToCharArray();

        //    Array.Sort(sArray);
        //    Array.Sort(tArray);

        //    for (var i = 0; i < sArray.Length; i++)
        //    {
        //        if (sArray[i] != tArray[i])
        //            return false;
        //    }
        //    return true;
        //}
    }
}
