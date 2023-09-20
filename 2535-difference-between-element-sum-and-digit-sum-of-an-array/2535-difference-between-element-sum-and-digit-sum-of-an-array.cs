public class Solution {
    public int DifferenceOfSum(int[] nums) {
             int ans = 0,elementSum=0,digitSum=0;
        foreach (var num in nums)
        {
            elementSum += num;
        }

        List<int> elements = new();
        foreach (var num in nums)
        {
            if (num > 9)
            {
                //split number in each element
               elements.AddRange(GetDigits(num)); 
            }
            else
            {
                elements.Add(num);
            }
        }

        foreach (var element in elements)
        {
            digitSum += element;
        }

        ans = Math.Abs(elementSum) - Math.Abs(digitSum);
        return ans;   
    }
    
        public static int[] GetDigits(int num)
    {
        List<int> digits = new();
        int temp = num;
        while (num>0)
        {
            temp = num % 10;
            num = num /10;
            digits.Add(temp);
        }

        return digits.ToArray();
    }
}