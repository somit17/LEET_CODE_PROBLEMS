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
    public ListNode SwapNodes(ListNode head, int k) {
         int pos = 0, length = 0;
        ListNode current = head,left=current,right=head;
        for (int i = 0; i < k-1; i++)
        {
            current = current.next;
        }
        left = current;
        while (current.next is not null)
        {
            current = current.next;
            right = right.next;
        }

        (left.val, right.val) = (right.val, left.val);
        return head;
    }
}