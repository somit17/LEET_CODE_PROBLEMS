public class Solution {
    public int[] TwoSum(int[] array, int target) {
 int[] returnArray = new int[2];
        Dictionary<int, int> map = new();
        int compliment = 0;
        for (int x = 0; x < array.Length; x++)
        {
            compliment = target - array[x];
            if (map.ContainsKey(compliment))
            {
                // Found a pair that adds up to the target
                return new int[] { map[compliment], x};
            }
            // Otherwise, add the current number and its index to the dictionary
   if (!map.ContainsKey(array[x]))
            {
                map.Add(array[x], x);
            }
            map[array[x]] = x;
        }
        return returnArray;

    }
}