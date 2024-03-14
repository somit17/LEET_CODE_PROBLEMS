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
    public int PairSum(ListNode head) {
       ListNode current = head;
        List<int> list = new List<int>();
        while (current != null)
        {
           list.Add(current.val);
            current = current.next;
        }

        int hPointer = 0, ePointer = list.Count-1;
        int maxSum = -1, currentSum = 0;
        while (hPointer <= ePointer)
        {
            currentSum = list.ElementAt(hPointer) + list.ElementAt(ePointer);
            maxSum = Math.Max(currentSum, maxSum);
            hPointer++;
            ePointer--;
        }

        return maxSum; 
    }
}