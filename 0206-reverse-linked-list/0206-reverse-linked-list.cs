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
    public ListNode ReverseList(ListNode head) {
        if (head == null)
        {
            return null;
        }

    ListNode prev=null, next;
        while (head!=null)
        {
            next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }

       
        return prev;
    }
}