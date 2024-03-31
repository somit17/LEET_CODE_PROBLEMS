public class Solution {
    public int MinSetSize(int[] arr) {
         Dictionary<int, int> map = new Dictionary<int, int>();
        foreach (int val in arr)
        {
            if (map.ContainsKey(val))
            {
                map[val]++;
            }
            else
            {
                map[val] = 1;
            }
        }


        PriorityQueue<int, int> heap = new PriorityQueue<int, int>(Comparer<int>.Create((a,b)=>b-a));
        foreach (var item in map)
        {
            heap.Enqueue(item.Value, item.Value);
        }

        var size = arr.Length/2; 
        
        var currentCount = 0; 
        var result = 0; 
        
        while(heap.Count != 0 && currentCount < size)
        {
            var current = heap.Dequeue(); 
            currentCount += current;
            result++;
            
        }
        
        return result;
    }
}