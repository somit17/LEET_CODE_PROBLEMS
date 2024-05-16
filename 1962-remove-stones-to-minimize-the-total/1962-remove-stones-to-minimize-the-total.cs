public class Solution {
    public int MinStoneSum(int[] piles, int k) {
         var maxPriorityQueue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach (var pile in piles)
            maxPriorityQueue.Enqueue(pile, pile);
        while (k >0)
        {
            var topElement = Convert.ToInt32(Math.Ceiling((double)maxPriorityQueue.Dequeue() / 2));
            maxPriorityQueue.Enqueue(topElement, topElement);
            k--;
        }

        int result = 0;
        while (maxPriorityQueue.Count > 0)
            result += maxPriorityQueue.Dequeue();
        return result;
    }
}