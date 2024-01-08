public class Solution {
    public int NumberOfSteps(int num) {
         int stepCounter = 0;
        while (num>0)
        {
            if ((num & 1) == 1)
            {
                num--;
                
            }
            else
            {
                num = num / 2;
            }

            stepCounter++;
        }
        return stepCounter;
    }
}