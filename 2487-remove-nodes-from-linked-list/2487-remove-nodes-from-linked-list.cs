/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNodes(ListNode head)
    {
        var reversedLinkedList = ReverseLinkedList(head);
        var revHead = reversedLinkedList;
        ListNode dummyNode = new ListNode(0);
        dummyNode.next = revHead;
        var prev = dummyNode;

        while (revHead != null)
        {
            if (prev.val > revHead.val)
                prev.next = revHead.next;
            else prev = prev.next;
            revHead = revHead.next;
        }

        return ReverseLinkedList(dummyNode.next);
    }

    public ListNode ReverseLinkedList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;
        ListNode lastNode = ReverseLinkedList(head.next);
        head.next.next = head;
        head.next = null;
        return lastNode;
    }
}