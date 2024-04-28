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
    public ListNode[] SplitListToParts(ListNode head, int k) {
       ListNode current = head;
        int length = 0;
        while (current != null)
        {
            length ++;
            current = current.next;
        }

        int eachBuckeNodes = length / k, remainderNodes = length % k;
        ListNode[] result=new ListNode[k];
        current = head;
        ListNode prev = null;
        for (int i = 0; i < k; i++)
        {
            result[i] = current;
            for (int count = 1; count <= eachBuckeNodes + (remainderNodes > 0 ? 1 : 0); count++)
            {
                prev = current;
                current = current.next;
            }
 
            if (prev != null)
                prev.next = null;
            remainderNodes--;
        }

        return result;
    }
}