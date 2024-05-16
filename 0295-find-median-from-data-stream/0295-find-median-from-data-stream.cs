public class MedianFinder {
    PriorityQueue<double, double> leftMaxHeap;
    PriorityQueue<double, double> rightMinHeap;

    public MedianFinder() {
        leftMaxHeap = new PriorityQueue<double, double>(Comparer<double>.Create((x, y) => y.CompareTo(x)));
        rightMinHeap = new PriorityQueue<double, double>(Comparer<double>.Create((x, y) => x.CompareTo(y)));
    }
    
    public void AddNum(int num) {
        
        if (num > (leftMaxHeap.Count > 0 ? leftMaxHeap.Peek() : 0))
            rightMinHeap.Enqueue(num, num);
        else leftMaxHeap.Enqueue(num, num);

        //always maintain left heap greater than 1 on right
        if (Math.Abs(rightMinHeap.Count - leftMaxHeap.Count) > 1)
        {
            var deque = leftMaxHeap.Dequeue();
            rightMinHeap.Enqueue(deque, deque);
        }

        else if (leftMaxHeap.Count < rightMinHeap.Count)
        {
            var deque = rightMinHeap.Dequeue();
            leftMaxHeap.Enqueue(deque, deque);
        }
    }
    
    public double FindMedian() {
        if (leftMaxHeap.Count == rightMinHeap.Count)
        return (leftMaxHeap.Peek() + rightMinHeap.Peek())/2;
        return leftMaxHeap.Peek();
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */