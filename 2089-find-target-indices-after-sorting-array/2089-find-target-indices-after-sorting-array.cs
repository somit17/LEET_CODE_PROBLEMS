public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
      List<int> targetIndicesList = new();
        System.Array.Sort(nums);
        int startIndex = LowerBound(nums,target);
        
       int endIndex = UpperBound(nums,target);
         if (startIndex != endIndex)
       {
            for(int i=startIndex;i<=endIndex;i++)
           targetIndicesList.Add(i);
   
       }else if (startIndex != -1 || endIndex != -1)
       {
           targetIndicesList.Add(startIndex);  
       }
        
        return targetIndicesList;  
    }
    public  int LowerBound(int[] nums, int target)
    {
        int low = 0, high = nums.Length - 1;
        int ans = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (nums[mid] == target)
            {
                ans = mid;
                high = mid - 1;
            }
            else if (nums[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return ans;
    }

    public  int UpperBound(int[] nums, int target)
    {
        int low = 0, high = nums.Length - 1;
        int ans = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (nums[mid] == target)
            {
                ans = mid;
                low = mid + 1;
            }
            else if (nums[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return ans;
    }
}