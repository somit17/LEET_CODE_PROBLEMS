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
    public int GetDecimalValue(ListNode head) {
        StringBuilder s = new();
        ListNode current = head;
        while (current != null)
        {
            s.Append(current.val);
            current = current.next;
        }

        return Convert.ToInt32(s.ToString(), 2);
    }
}