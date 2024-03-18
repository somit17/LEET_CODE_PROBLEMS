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
         //DummyNode
        ListNode dummyNode = new ListNode()
        {
            val = 0,
            next = head
        };

        ListNode prev = dummyNode, current = head;
        while (current != null && current.next != null)
        {
            //Save pointers
            ListNode secondNextPtr = current.next.next, nextPtr = current.next;

            //Reverse pairs
            nextPtr.next = current;
            current.next = secondNextPtr;
            prev.next = nextPtr;
            
            
            //UpdatePtrs
            prev = current;
            current = current.next;
        }

        return dummyNode.next; 
    }
}