public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> allSubsets= new List<IList<int>>();
        GenerateSubsets( allSubsets,new List<int>(), nums,0);
        return allSubsets;
    }
    public void GenerateSubsets(IList<IList<int>> allSubsets,List<int> currentSubset ,int[] nums,int i){
        if(i>=nums.Length)
        {   
            allSubsets.Add(new List<int>(currentSubset));
            return;
        }
        currentSubset.Add(nums[i]);
        GenerateSubsets( allSubsets, currentSubset , nums, i+1);
        currentSubset.RemoveAt(currentSubset.Count-1);   
        GenerateSubsets( allSubsets, currentSubset , nums, i+1);    
    }
}