public class Solution {
    public int SubsetXORSum(int[] nums) {
        List<int> numsList = new();
        foreach (var num in nums)
        {
            numsList.Add(num);
        }

        List<List<int>> res = Subsets(numsList);
        int sum = 0;
        foreach (var subset in res)
        {
            sum += ReturnXoRResult(subset);
        }
        return sum;
    }public  int ReturnXoRResult(List<int> ar)
    {
        int xorResult = 0;
        if (ar.Count == 0)
        {
            return 0;}
        foreach (var a in ar)
        {
            xorResult ^= a;
        }

        return xorResult;
    }
     List<List<int> > Subsets(List<int> A)
    {
        List<int> subset = new List<int>();
        List<List<int> > res = new List<List<int> >();
        int index = 0;
        CalcSubset(A, res, subset, index);
        return res;
    }
     static void CalcSubset(List<int> nums,List<List<int>> res,List<int> subset,int index)
    {
        // Add the current subset to the result list
        res.Add(new List<int>(subset));
        // Generate subsets by recursively including and excluding elements
        for (int i = index; i < nums.Count; i++) {
            // Include the current element in the subset
            subset.Add(nums[i]);
 
            // Recursively generate subsets with the current
            // element included
            CalcSubset(nums, res, subset, i + 1);
 
            // Exclude the current element from the subset
            // (backtracking)
            subset.RemoveAt(subset.Count - 1);
        }
    }
}