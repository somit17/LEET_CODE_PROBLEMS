public class Solution {
    IList<IList<int>> allSubsets = new List<IList<int>>();
    List<int> currSubset = new();

    public IList<IList<int>> Subsets(int[] nums)
    {
        BackTrackingHelper(0, nums, currSubset, allSubsets);
        return allSubsets;
    }

    public void BackTrackingHelper(int i, int[] nums, List<int> currSubset, IList<IList<int>> allSubsets)
    {
        if (i >= nums.Length)
        {
            allSubsets.Add(new List<int>(currSubset));
            return;
        }
        //Decision  to add element 
        currSubset.Add(nums[i]);
        BackTrackingHelper(i + 1, nums, currSubset, allSubsets);
        currSubset.Remove(nums[i]);
        //Decision not to add element
        BackTrackingHelper(i + 1, nums, currSubset, allSubsets);
    }
}