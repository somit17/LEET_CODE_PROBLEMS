public class Solution {
    private List<int> result = new List<int>();
    private List<int> tempResult = new List<int>();


    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        System.Array.Sort(nums);

        int n = nums.Length;
        int[] t = new int[n];
        System.Array.Fill(t, 1);

        int[] prevIdx = new int[n];
        System.Array.Fill(prevIdx, -1);

        int lastChosenIndex = 0;
        int maxL = 1;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < i; j++) {
                if (nums[i] % nums[j] == 0) {
                    if (t[i] < t[j] + 1) {
                        t[i] = t[j] + 1;
                        prevIdx[i] = j;
                    }

                    if (t[i] > maxL) {
                        maxL = t[i];
                        lastChosenIndex = i;
                    }
                }
            }
        }

        List<int> result = new ();
        while (lastChosenIndex >= 0) {
            result.Add(nums[lastChosenIndex]);
            lastChosenIndex = prevIdx[lastChosenIndex];
        }

        return result;
    }

    private int Solve(int[] nums, int[][] dp, int currentIndex, int prevIndex)
    {
        if (currentIndex == nums.Length)
        {
            // Check if the current subset is larger than the best found so far
            if (tempResult.Count > result.Count)
            {
                result = new List<int>(tempResult);
            }

            return 0;
        }

        if (prevIndex != -1 && dp[currentIndex][prevIndex] != -1)
            return dp[currentIndex][prevIndex];
        int taken = 0;
        if (prevIndex == -1 || nums[currentIndex] % nums[prevIndex] == 0)
        {
            tempResult.Add(nums[currentIndex]);
            taken = 1 + Solve(nums, dp, currentIndex + 1, currentIndex);
            tempResult.RemoveAt(tempResult.Count - 1); // Backtrack
        }
        int notTaken = Solve(nums, dp, currentIndex + 1, prevIndex);
        return Math.Max(taken, notTaken);
    }
}