public class Solution {
    public int[] SumZero(int n) {
        int lastVal = 0;
        List<int> uniqueList = new();
        bool isOdd = false;
        if ((n & 1) == 1)
        {
            n = n - 1;
            lastVal = n / 2;
            isOdd = true;
        }
        else
        {
            lastVal = n / 2;
        }

        for (int i = 1; i <= lastVal; i++)
        {
            uniqueList.Add(i);
            uniqueList.Add(-i);
        }

        if (isOdd)
        {
            uniqueList.Add(0);
        }
        return uniqueList.ToArray();
    }
}