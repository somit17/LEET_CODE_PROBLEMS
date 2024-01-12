public class Solution {
    public int CountTestedDevices(int[] batteryPercentages) {
        int testerCount = 0,n=batteryPercentages.Length;
        for (int i = 0; i < n; i++)
        {
            //Brute Force
            // int j = n-1;
            // if (batteryPercentages[i] > 0)
            // {
            //     while (j!=i)
            //     {
            //         batteryPercentages[j] = Math.Max(0,batteryPercentages[j] - 1);
            //         j--;
            //     }
            //
            //     testerCount++;
            // }
            
            //Optimal
            if (batteryPercentages[i] > testerCount)
            {
                testerCount++;
            }
            
        }

        return testerCount;
    }
}