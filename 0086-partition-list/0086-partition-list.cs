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
    public ListNode Partition(ListNode head, int n) {
        ListNode left=new ListNode(), right=new( ),leftTail=left,rightTail=right;
        while (head!=null)
        {
            if (head.val < n)
            {
                leftTail.next = head;
                leftTail = leftTail.next;
            }
            else
            {
                rightTail.next = head;
                rightTail = rightTail.next;
            }
            head = head.next;
        }

        leftTail.next = right.next;
        rightTail.next = null;
        return left.next;
    }
}