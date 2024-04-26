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
    public ListNode MergeKLists(ListNode[] lists)
    {
        int k = lists.Length;
        if (k == 0)
            return null;
        return PartitionLists(0, k - 1, lists);
    }

    public ListNode PartitionLists(int start,int end,ListNode[] ls)
    {
        if (start > end) return null;
        if (start == end) return ls[start];
        int mid = start + (end - start) / 2;
        ListNode l1 = PartitionLists(start, mid,ls);
        ListNode l2 = PartitionLists(mid + 1, end, ls);
        return MergeTwoSortedLists(l1, l2);
    }
    
    
    public ListNode MergeTwoSortedLists(ListNode l1, ListNode l2)
    {
        var dummyNode = new ListNode();
        var current = dummyNode;
        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                current.next = l1;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }
        // Append the remaining nodes
        if (l1 != null) current.next = l1;
        else if (l2 != null) current.next = l2;
        // Return the merged list
        return dummyNode.next;
    }
}