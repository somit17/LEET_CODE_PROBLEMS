public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
          Array.Sort(hours);
        int empCount = 0;
        for (int i = 0; i < hours.Length; i++)
        {
            if (hours[i] >= target) empCount++;
        }
        return empCount;
    }
}