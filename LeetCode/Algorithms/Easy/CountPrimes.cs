using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class CountPrimes : IQuestion
    {
        private const string question = "Count Primes";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int n = 30;
            Console.WriteLine(solution(n));
        }

        private static int solution(int n)
        {
            var primes = new bool[n + 1];
            for (var i = 0; i < n; i++)
            {
                primes[i] = true;
            }

            for (var p = 2; p * p <= n; p++)
            {
                if (primes[p])
                {
                    for (var i = p * 2; i <= n; i += p)
                    {
                        primes[i] = false;
                    }
                }
            }

            var result = 0;
            for (var i = 2; i <= n; i++)
            {
                if (primes[i])
                    result++;
            }
            return result;
        }

        //private static int alternateSolution(int n)
        //{
        //    var result = 0;
        //    for (var i = 2; i < n; i++)
        //    {
        //        result += isPrime(i) ? 1 : 0;
        //    }
        //    return result;
        //}

        //private static bool isPrime(int n)
        //{
        //    if (n == 2)
        //        return true;

        //    for (var i = 2; i <= Math.Sqrt(n); i++)
        //    {
        //        if (n%i == 0)
        //            return false;
        //    }
        //    return true;
        //}
    }
}
