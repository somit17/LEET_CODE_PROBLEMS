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
    public ListNode OddEvenList(ListNode head) {
       if (head == null || head.next == null)
        {
            return head;
        }
        ListNode odd = head, evenStart = head.next, even = head.next;
        
        while (odd.next != null && even.next != null)
        {
            odd.next = even.next;
            even.next = even.next.next;
            odd = odd.next;
            even = even.next;
        }

        odd.next = evenStart;
        return head; 
    }
}