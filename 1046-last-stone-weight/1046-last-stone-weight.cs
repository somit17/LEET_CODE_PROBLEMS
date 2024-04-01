public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a,b)=>b-a));
        foreach (var item in stones)
        {
            pq.Enqueue(item,item);
        }

        while (pq.Count>1)
        {
            int maxElement = pq.Dequeue();
            if (pq.Peek() != maxElement)
            {
                int ele = pq.Dequeue();
                pq.Enqueue(maxElement-ele,maxElement-ele);
            }
            else
            {
                 pq.Dequeue();
            }
        }

        return pq.Count>0?pq.Dequeue():0;
    }
}