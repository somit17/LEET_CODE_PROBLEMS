public class Solution {
    public int CountOdds(int low, int high) {
        int res = 0;
        while (low <= high)
        {
            if ((low & 1) == 1) res++;
            low++;
            
        }

        return res;
    }
}