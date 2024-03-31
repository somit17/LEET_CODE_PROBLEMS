public class Solution {
    public int MinimumOperations(int[] nums) {
            int res = 0;
        var pq = new PriorityQueue<int, int>();
        foreach (var item in nums)
        {
            pq.Enqueue(item, item);
        }

        int num = 0;
        while (pq.Count > 0)
        {
            if (pq.Peek() == 0)
            {
                pq.Dequeue();
            }
            else
            {
                int temp = pq.Peek() - num;
                if (temp != 0)
                {
                    num = temp + num;
                    res++;
                }
                pq.Dequeue();
            }
        }

        return res;
    }
}