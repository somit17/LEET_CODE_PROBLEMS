public class Solution {
    public  int NumOfSubarrays(int[] arr, int k, int threshold)
    {
        int  result = 0,currentSum=arr.Take(k-1).Sum();    
        for (int Left = 0; Left < arr.Length - k+1; Left++)
        {
            currentSum += arr[Left + k-1];
            if (currentSum / k >= threshold)
                result += 1;
            currentSum -= arr[Left];
        }

        return result;
    }
}