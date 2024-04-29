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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
       if (head == null)
        {
            return head;
        }

        var current = head;
        int length = 0;
        while (current != null)
        {
            length += 1;
            current = current.next;
        }

        ListNode dummyNode = new(0);
        dummyNode.next = head;
        current = head;
        var prev = dummyNode;
        int k = length - n;
        while (k > 0 && current != null)
        {
            current = current.next;
            prev = prev.next;
            k--;
        }

        prev.next = current.next;
        return dummyNode.next;
    }
}