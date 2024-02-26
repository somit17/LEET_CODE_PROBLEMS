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
    public bool IsPalindrome(ListNode head) {
        if (head == null)
        {
            return false;
        }
        string nodesData = TraverserNode(head);
        int lP = 0,
            rP = nodesData.Length-1;
        while (lP < rP)
        {
            if (nodesData[lP] != nodesData[rP])
            {
                return false;
            }

            lP++;
            rP--;
        }

        return true;
    }
    
    public string TraverserNode(ListNode head)
    {
        StringBuilder nodesData = new StringBuilder();
        ListNode current = head;
        while (current != null)
        {
            nodesData.Append(current.val);
            current = current.next;
        }

        return nodesData.ToString();
    }
}