using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class DeleteLinkedListNode : IQuestion
    {
        private const string question = "Delete Node in a Linked List";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head = Utility.GetLinkedList(new[] {1, 2, 3, 4, 5});
            var node = head.next.next;

            solution(node);
            Utility.PrintLinkedList(head);
        }

        private static void solution(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
