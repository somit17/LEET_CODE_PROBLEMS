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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(head==null||head.next==null){
            return head;
        }

        ListNode dummy= new(0);
        dummy.next = head;

        ListNode prev = dummy;
        for (int i = 1; i < left; i++)
            prev = prev.next;

        ListNode current = prev.next;
        for (int i = 1; i <= right - left; i++)
        {
            var temp = prev.next;
            prev.next = current.next;
            current.next = current.next.next;
            prev.next.next = temp;
        }
        
        return dummy.next;
    }
}