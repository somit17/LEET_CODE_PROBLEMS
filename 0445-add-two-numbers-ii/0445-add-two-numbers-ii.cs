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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
       Stack<int> s1 = new(), s2 = new();
        while (l1 != null)
        {
            s1.Push(l1.val);
            l1 = l1.next;
        }
        while (l2 != null)
        {
            s2.Push(l2.val);
            l2 = l2.next;
        }

        int sum = 0, carry = 0;
        ListNode ans = new();
        while (s1.Count > 0 || s2.Count > 0)
        {
            if (s1.Count > 0)
                sum += s1.Pop();
            if (s2.Count > 0)
                sum += s2.Pop();
            ans.val = sum % 10;
            carry = sum / 10;
            ListNode newNode = new ListNode(carry);
            newNode.next = ans;
            ans = newNode;
            sum = carry;
        }

   return carry==0?ans.next:ans;
    }
}