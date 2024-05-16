public class Index1Index2
{
    public int Index1;
    public int Index2;

    public Index1Index2(int index1, int index2)
    {
        Index1 = index1;
        Index2 = index2;
    }
}
public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
    {
        int n = nums1.Length;
        int m = nums2.Length;
        var priorityQueue = new PriorityQueue<Index1Index2, int>();
        for (int i = 0; i < n; i++)
            priorityQueue.Enqueue(new Index1Index2(i, 0), nums1[i] + nums2[0]);

        IList<IList<int>> result = new List<IList<int>>();
        while (result.Count < k && priorityQueue.Count > 0)
        {
            var dequeued = priorityQueue.Dequeue();
            int index1 = dequeued.Index1;
            int index2 = dequeued.Index2;
            result.Add(new List<int>() { nums1[index1], nums2[index2] });
            index2++;
            if (index2 < nums2.Length)
            {
                priorityQueue.Enqueue(new Index1Index2(index1, index2), nums1[index1] + nums2[index2]);
            }
        }

        return result;
    }
}