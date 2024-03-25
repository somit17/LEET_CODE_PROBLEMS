public class Solution {
    
    List<int> currentSubset = new();
    private List<List<int>> allSubsets = new();
      public int CountMaxOrSubsets(int[] nums)
    {
        int maxOR = 0;
        foreach (var num in nums)
        {
            maxOR |= num;
        }

        int result = 0;
        GenerateSubsetsBackTrack(0, nums, currentSubset, allSubsets);
        foreach (var eachSubset in allSubsets)
        {
            int subsetORResult = 0;
            foreach (var numInEachSubset in eachSubset)
            {
                subsetORResult |= numInEachSubset;
            }

            if (subsetORResult == maxOR)
            {
                result++;
            }
        }

        return result;
    }
    public void GenerateSubsetsBackTrack(int i, int[] nums, List<int> currentSubset, List<List<int>> allSubsets)
    {
        if (i >= nums.Length)
        {
            allSubsets.Add(new List<int>(currentSubset));
            return;
        }

        //Decision to add element
        currentSubset.Add(nums[i]);
        GenerateSubsetsBackTrack(i + 1, nums, currentSubset, allSubsets);
        currentSubset.Remove(nums[i]);

        //Decision to not add element
        GenerateSubsetsBackTrack(i + 1, nums, currentSubset, allSubsets);
    }
}