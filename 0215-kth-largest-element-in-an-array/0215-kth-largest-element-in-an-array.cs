public class Solution {
    public int FindKthLargest(int[] nums, int k) {
       //Max Heap
        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach (var num in nums)
            maxHeap.Enqueue(num, num);
        int dequeElementsCount = k - 1;
        while (dequeElementsCount > 0)
        {
            if (maxHeap.Count > 0)
                maxHeap.Dequeue();
            dequeElementsCount--;
        }
        return maxHeap.Dequeue(); 
    }
}