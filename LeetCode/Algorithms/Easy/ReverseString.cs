using System;
using System.Text;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class ReverseString : IQuestion
    {
        private const string question = "Reverse String";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const string s = "hello";
            Console.WriteLine(solution(s));
        }

        private static string solution(string s)
        {
            var sb = new StringBuilder();
            for (var i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }

        //private static string alternateSolution(string s)
        //{
        //    var i = 0;
        //    var j = s.Length - 1;

        //    var arr = s.ToCharArray();
        //    while (i < j)
        //    {
        //        var temp = arr[i];
        //        arr[i] = arr[j];
        //        arr[j] = temp;

        //        i++;
        //        j--;
        //    }
        //    return new String(arr);
        //}
    }
}
