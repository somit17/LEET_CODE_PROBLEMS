public class Solution {
    public int PivotInteger(int n) {
        int left = 1, right = n;
        
        while(left <= right)
        {
            int mid = left + ((right - left) / 2);
            int lsum = (mid * (mid + 1)) / 2;
            int rsum = ((n * (n + 1)) / 2) - lsum + mid;
            
            if(lsum == rsum)
                return mid;
            else if(lsum < rsum)
                left = mid + 1;
            else
                right = mid - 1;
        }
        
        return -1;
    }
}