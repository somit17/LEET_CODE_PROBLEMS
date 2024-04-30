public class Solution {
    public int[] SearchRange(int[] nums, int target)
    {
        int leftMost, rightMost;
        leftMost = FindLeftMostPos(nums, target);
        rightMost = FindRightMostPos(nums, target);
        return new int[] { leftMost, rightMost };
    }

    int FindLeftMostPos(int[] nums, int target)
    {
        int length = nums.Length;
        int leftmost = -1, L = 0, R = length - 1;
        while (L <= R)
        {
            int mid = L + (R - L) / 2;
            if (nums[mid] == target)
            {
                leftmost = mid;
                R = mid - 1;
            }
            else if (target > nums[mid])
                L = mid + 1;
            else
                R = mid - 1;
        }

        return leftmost;
    }

    int FindRightMostPos(int[] nums, int target)
    {
        int length = nums.Length;
        int rightmost = -1, L = 0, R = length - 1;
        while (L <= R)
        {int mid = L + (R - L) / 2;
            if (nums[mid] == target)
            {
                rightmost = mid;
                L = mid + 1;
            }
            else if (target > nums[mid])
                L = mid + 1;
            else
                R = mid - 1;
        }

        return rightmost;
    }
}