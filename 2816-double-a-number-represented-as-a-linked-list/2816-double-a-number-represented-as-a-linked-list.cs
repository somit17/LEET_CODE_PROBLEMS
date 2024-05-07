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
    public ListNode DoubleIt(ListNode head) {
      if (head == null)
            return null;
        var current = head;
        StringBuilder dig = new StringBuilder();
        while (current != null)
        {
            dig.Append(current.val.ToString());
            current = current.next;
        }
        string numStr = dig.ToString();
        int n = numStr.Length;
        int carry = 0;
        List<int> digits = new List<int>();
        for (int i = n - 1; i >= 0; i--)
        {
            int digit = numStr[i] - '0';
            int result = digit * 2 + carry;
            digits.Insert(0, result % 10);
            carry = result / 10;
        }

        while (carry > 0)
        {
            digits.Insert(0, carry % 10);
            carry /= 10;
        }
        ListNode dummyNode = new ListNode(0);
        var doubleHead = dummyNode;
        foreach (var eDigit in digits)
        {
            ListNode newNode = new ListNode(eDigit);
            dummyNode.next = newNode;
            dummyNode = dummyNode.next;
        }

        return doubleHead.next;
    }
}