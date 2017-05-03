using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class ReverseLinkedList : IQuestion
    {
        private const string question = "Reverse Linked List";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head = Utility.GetLinkedList(new[] {1, 2, 3, 4, 5});
            Utility.PrintLinkedList(solution(head));
        }

        private static ListNode solution(ListNode head)
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
    }
}
