using System;
using System.Collections.Generic;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class PascalsTriangle : IQuestion
    {
        private const string question = "Pascal's Triangle";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            const int numRows = 5;

            var result = solution(numRows);
            foreach (var list in result)
            {
                foreach (var item in list)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }

        private static List<List<int>>  solution(int numRows)
        {
            var result = new List<List<int>>();
            for (var i = 0; i < numRows; i++)
            {
                var rows = new List<int>();
                for (var j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i)
                    {
                        rows.Add(1);
                    }
                    else
                    {
                        rows.Add(result[i-1][j-1] + result[i-1][j]);  
                    }
                }
                result.Add(rows);
            }
            return result;
        }
    }
}
