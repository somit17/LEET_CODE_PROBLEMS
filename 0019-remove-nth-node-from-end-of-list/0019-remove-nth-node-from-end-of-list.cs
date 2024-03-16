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
 ListNode end = head, current = head, next;
        int pos = 0, length = 0;
        while (end != null)
        {
            end = end.next;
            length++;
        }

        if (length == 1 || n>length)
        {
            return null;
        }

        pos = length == n ? 0 : length - n - 1;
        while (pos != 0 && current != null)
        {
            current = current.next;
            pos--;
        }

        next = current.next;
        current.next = length == n ? null : next.next;

        return length == n ? next : head;
    }
}