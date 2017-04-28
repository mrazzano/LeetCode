using System;
using System.Diagnostics;
using LeetCode.Library;
using LeetCode.Algorithms;

namespace LeetCode
{
    class Program
    {
        static void Main()
        {
            const string header = "Solutions to LeetCode exercises.";

            // write program header
            Console.WriteLine(Utility.GetProgramHeader(header));

            // start program timer
            var timer = new Stopwatch();
            timer.Start();

            new AlgorithmModule().Execute();

            // stop timer
            timer.Stop();

            // write timer output
            Console.WriteLine("Program Execution: {0}ms", timer.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
