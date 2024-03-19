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
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        ListNode newNode, current = head,prev=head,temp,next=current.next;
        while (current!=null && current.next!=null)
        {
            temp = current.next;
            int hcf = gcd(current.val, next.val);
            newNode = new ListNode()
            {
                val = hcf,
                next = temp
            };
            current.next = newNode;
            current = current.next.next;
            next = next.next;
        }
        return head;
    }
    public int gcd(int val1, int val2)
    {
        //Find Min of val1 and val2
        int result = Math.Min(val1, val2);
        while (result > 0)
        {
            if (val1 % result == 0 && val2 % result == 0)
            {
                break;
            }

            result--;
        }

        return result;
    }
}