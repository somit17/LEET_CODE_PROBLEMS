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
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null)
            return head;
        //A=head;
        //B=head.next;
        //C=head.next.next;
        //A->B->C->....
        
        //A->C
        ListNode temp = head.next;
        head.next = SwapPairs(head.next.next);
        temp.next = head;
        return temp;
    }
}