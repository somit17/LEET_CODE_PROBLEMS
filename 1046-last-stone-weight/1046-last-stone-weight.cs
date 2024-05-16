public class Solution {
    public int LastStoneWeight(int[] stones) {
        var maxPriorityQueue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach (var eachStone in stones)
            maxPriorityQueue.Enqueue(eachStone, eachStone);

        while (maxPriorityQueue.Count > 1)
        {
            var maxElement1 = maxPriorityQueue.Dequeue();
            var secondMaxElement = maxPriorityQueue.Dequeue();
            int res = maxElement1 - secondMaxElement;
            maxPriorityQueue.Enqueue(res, res);
        }

        return maxPriorityQueue.Dequeue();;
    }
}