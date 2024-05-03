public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        int m = spells.Length;
        int n = potions.Length;
    
        System.Array.Sort(potions);
    
        int maxPotion = potions[n-1];
    
        List<int> answer = new List<int>();
    
        for(int i = 0; i<m; i++) {
            int spell = spells[i];
        
            long  minPotion = (long )Math.Ceiling((1.0*success)/spell);
        
            if(minPotion > maxPotion) {
                answer.Add(0);
                continue;
            }
        
            int index = BinarySearch(0, n-1, potions, (int)minPotion);//lower_bound(begin(potions), end(potions), minPotion) - begin(potions);
        
            answer.Add(n-index);
        }
    
        return answer.ToArray();
    }
    int BinarySearch(int l, int r, int[] potions, int target) {
        //we have to find the index of first element greater than or equal to target (minPotion)
        int index = -1;
        int mid = 0;
    
        while(l <= r) {
            mid = l + (r-l)/2;
        
            if(potions[mid] >= target) {
                index = mid;
                r = mid-1;
            } else {
                l = mid+1;
            }
        }
    
        return index;
    }
}