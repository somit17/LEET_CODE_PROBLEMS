public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
       System.Array.Sort(people);
        int boatCounts = 0;
        int left = 0, right = people.Length - 1;
        while (left <= right)
        {
            int sum = people[left] + people[right];
            if (sum <= limit)
            {
                boatCounts++;
                left++;
                right--;
            }
            else
            {
                boatCounts++;
                right--;
            }
            
        }

        return boatCounts; 
    }
}