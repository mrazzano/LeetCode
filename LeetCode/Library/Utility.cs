using System;
using System.Text;
using System.Collections.Generic;

namespace LeetCode.Library
{
    public static class Utility
    {
        private const int LineLength = 60;

        public static string GetProgramHeader(string header)
        {
            var separator = new string('*', LineLength);

            var sb = new StringBuilder();
            sb.AppendLine(separator);
            sb.AppendFormat("* {0}", header);
            sb.Append(Environment.NewLine);
            sb.AppendLine(separator);
            sb.AppendLine();

            return sb.ToString();
        }

        public static string GetLessonHeader(string header)
        {
            var separator = new string('-', LineLength);

            var sb = new StringBuilder();
            sb.AppendLine(separator);
            sb.AppendLine(header);
            sb.Append(separator);

            return sb.ToString();
        }

        public static void PrintArray(int[] array)
        {
            var sb = new StringBuilder();
            sb.Append("[");
            foreach (var item in array)
            {
                sb.AppendFormat("{0}, ", item);
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }

        public static ListNode GetLinkedList(int[] nodes)
        {
            ListNode lastListNode = null;
            for (var i = nodes.Length - 1; i >= 0; i--)
            {
                var node = new ListNode(nodes[i], lastListNode);
                lastListNode = node;
            }
            return lastListNode;
        }

        public static void PrintLinkedList(ListNode head)
        {
            var sb = new StringBuilder();
            var node = head;
            while (node != null)
            {
                sb.AppendFormat("{0}->", node.val);
                node = node.next;
            }
            Console.WriteLine(sb.ToString().Remove(sb.Length - 2, 2));
        }

        public static void RunQuestions(string header, IReadOnlyList<IQuestion> questions)
        {
            Console.WriteLine(GetLessonHeader(header));
            for (var i = 0; i < questions.Count; i++)
            {
                questions[i].Run(i + 1);
                Console.WriteLine();
            }
        }
    }
}