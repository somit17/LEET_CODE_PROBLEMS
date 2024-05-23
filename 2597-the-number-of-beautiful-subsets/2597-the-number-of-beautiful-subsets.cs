public class Solution {
    public int BeautifulSubsets(int[] nums, int k) {
        List<List<int>> allSubsets = new();
        GenerateSubsets( allSubsets,new List<int>(), nums, k, 0);
        return allSubsets.Count;
    }
    public void GenerateSubsets(List<List<int>> allSubsets,List<int> currentSubset,int[] nums,int k,int i){
        if (i == nums.Length) {
            if (IsBeautiful(currentSubset, k)) {
                if (currentSubset.Count > 0) {
                    allSubsets.Add(new List<int>(currentSubset));
                }
            }
            return;
        }
        currentSubset.Add(nums[i]);
        GenerateSubsets(allSubsets,currentSubset, nums, k, i+1);
        currentSubset.RemoveAt(currentSubset.Count-1);
        GenerateSubsets(allSubsets,currentSubset, nums, k, i+1);
    }
    private bool IsBeautiful(List<int> subset, int k) {
        for (int i = 0; i < subset.Count; i++) {
            for (int j = i + 1; j < subset.Count; j++) {
                if (Math.Abs(subset[i] - subset[j]) == k) {
                    return false;
                }
            }
        }
        return true;
    }
}