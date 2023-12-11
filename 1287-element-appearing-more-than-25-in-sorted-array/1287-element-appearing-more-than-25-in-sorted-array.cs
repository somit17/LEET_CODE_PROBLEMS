public class Solution {
    public int FindSpecialInteger(int[] arr) {
        Dictionary<int, int> hashMap = new();
        for (int i = 0; i < arr.Length; i++)
        {
            if (hashMap.ContainsKey(arr[i]))
            {
                int val;
                hashMap.TryGetValue(arr[i],out val);
                hashMap[arr[i]] = val + 1;
            }
            else
            {
                hashMap.Add(arr[i],0);
            }
        }

       return  hashMap.OrderByDescending(x => x.Value).FirstOrDefault().Key;
    }
}