public class Solution {
    public int[] SeparateDigits(int[] nums) {
        List<int> result = new();
        foreach (var num in nums)
        {
            //Temporary List
            List<int> tempList = new();
            int x = num;
            while (x > 0)
            {
                tempList.Add( x % 10);
                x = x / 10;
            }

            tempList.Reverse();
result.AddRange(tempList);
        } 
        return result.ToArray();
    }
}