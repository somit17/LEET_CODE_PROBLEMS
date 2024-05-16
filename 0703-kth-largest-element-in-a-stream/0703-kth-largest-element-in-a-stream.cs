public class KthLargest {
    PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
    int kThLargest;
    public KthLargest(int k, int[] nums) {
        kThLargest = k;
        foreach (var num in nums)
            Add(num);
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, val);
        if (minHeap.Count > kThLargest)
            minHeap.Dequeue();
        return minHeap.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */