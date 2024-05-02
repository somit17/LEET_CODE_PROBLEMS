public class Solution {
   public int MinEatingSpeed(int[] piles, int h)
    {
        int L = 1, R = piles.Max();
        while (L < R)
        {
            int mid = L + (R - L) / 2;
            if (CanEatAllPiles(piles, mid, h))
                R = mid;
            else L = mid + 1;
        }

        return L;
    }

    private bool CanEatAllPiles(int[] piles, int eachHourEating, int target)
    {
        int actualEatingCapacity = 0;
        foreach (var bananas in piles)
        {
            actualEatingCapacity +=  bananas / eachHourEating;
            if (bananas % eachHourEating != 0)                                  actualEatingCapacity++;
        }

        return actualEatingCapacity <= target;
    }
}