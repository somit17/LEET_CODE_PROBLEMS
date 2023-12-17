public class Solution {
    public int SumIndicesWithKSetBits(IList<int> nums, int k) {
        int sum = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            string s = Convert.ToString(i, 2);
            int counter = s.Where(x => x == '1').Count();
            if (counter == k)
            {
                sum += nums[i];
            }
        }

        return sum;
    }
}