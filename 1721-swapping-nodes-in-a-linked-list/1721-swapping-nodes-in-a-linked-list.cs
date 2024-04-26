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
     int Length = 0,L=k,R=0;
        ListNode current = head, Node1 = head, Node2 = head;
         while (current!= null)
        {
            current = current.next;
            Length += 1;
        }

        R = Length - k + 1;
        while (L > 1)
        {
            Node1 = Node1.next;
            L--;
        }

        while (R > 1)
        {
            Node2 = Node2.next;
            R--;
        }

        (Node1.val, Node2.val) = (Node2.val, Node1.val);
        return head;   
    }
}