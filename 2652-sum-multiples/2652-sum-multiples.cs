public class Solution {
    public int SumOfMultiples(int n) {
         List<int> arr = new();
            List<int> returnArray = new();
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                arr.Add(i);
            }

            foreach (var item in arr)
            {
                if (item % 3 == 0 || item % 5 == 0 || item % 7 == 0)
                {
                    returnArray.Add(item);
                }
            }

            foreach (var num in returnArray)
            {
                sum += num;
            }
            return  sum;
    }
}