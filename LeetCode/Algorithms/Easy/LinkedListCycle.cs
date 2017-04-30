using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class LinkedListCycle : IQuestion
    {
        private const string question = "Linked List Cycle";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head = Utility.GetLinkedList(new[] {1, 2, 3, 4, 5});
            head.next.next.next = head.next;

            Console.WriteLine(solution(head));
        }

        private static bool solution(ListNode head)
        {
            if (head == null)
                return false;

            var walker = head;
            var runner = head;

            while (runner.next != null && runner.next.next != null)
            {
                walker = walker.next;
                runner = runner.next.next;

                if (walker == runner)
                    return true;
            }
            return false;
        }
    }
}
