using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class PalindromeLinkedList : IQuestion
    {
        private const string question = "Palindrome Linked List";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head = Utility.GetLinkedList(new[] {1, 2, 2, 1});
            Console.WriteLine(solution(head));
        }

        private static bool solution(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            slow = reverse(slow);
            fast = head;

            while (slow != null)
            {
                if (slow.val != fast.val)
                    return false;

                slow = slow.next;
                fast = fast.next;
            }
            return true;
        }

        private static ListNode reverse(ListNode head)
        {
            ListNode newHead = null;
            while (head != null)
            {
                var next = head.next;
                head.next = newHead;
                newHead = head;
                head = next;
            }
            return newHead;
        }

        //private static bool alternativeSolution(ListNode head)
        //{
        //    var list = new List<int>();
        //    while (head != null)
        //    {
        //        list.Add(head.val);
        //        head = head.next;
        //    }

        //    var i = 0;
        //    var j = list.Count - 1;
        //    while (i < j)
        //    {
        //        if (list[i] != list[j])
        //        {
        //            return false;
        //        }
        //        i++;
        //        j--;
        //    }
        //    return true;
        //}
    }
}
