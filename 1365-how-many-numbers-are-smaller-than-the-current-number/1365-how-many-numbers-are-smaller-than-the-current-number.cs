public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        List<int> returnArray = new();
        Dictionary<int, int> hashMap = new();
        if (nums.Length == 0)
        {
            return returnArray.ToArray();
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashMap.ContainsKey(nums[i]))
                {
                    hashMap[nums[i]]++;
                }else
                {
                    hashMap.Add(nums[i],1);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                var smallerNumThanSum = hashMap.Where(x => x.Key < num).ToList().Sum(x => x.Value);
                returnArray.Add(smallerNumThanSum);
            }
        }
        return returnArray.ToArray();
    }
}