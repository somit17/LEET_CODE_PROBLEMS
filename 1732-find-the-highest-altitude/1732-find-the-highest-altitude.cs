public class Solution {
    public int LargestAltitude(int[] gain) {
        int largestAltitude = 0;
        List<int> hashMap = new List<int>();
        hashMap.Add(0);
        for (int i=0;i<gain.Length;i++)
        {
            
            var altitude = hashMap[i]+gain[i];
            hashMap.Add(altitude);
        }

        largestAltitude = hashMap.Max();
        return largestAltitude; 
    }
}