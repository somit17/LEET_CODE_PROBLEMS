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
    public ListNode MiddleNode(ListNode head) {
        ListNode traverse = head;
        int totalPos = 0;
        while (traverse != null)
        {
            traverse = traverse.next;
            totalPos++;
        }

        int splitPos = totalPos / 2 ;
        ListNode current = head;
        while (splitPos!=0)
        {
            current = current.next;
            splitPos--;
        }

        head = current;
        return head;
    }
}