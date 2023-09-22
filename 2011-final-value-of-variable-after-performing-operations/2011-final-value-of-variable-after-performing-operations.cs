public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
          int length = operations.Length-1, finalAns = 0;
        while (length >= 0)
        {
            string index = operations[length];
            switch (index)
            {
                case "X++":
                    finalAns= finalAns+ 1;
                    break;
                case "++X":
                    finalAns= finalAns+ 1;
                    break;
                case "X--":
                    finalAns=finalAns- 1;
                    break;
                case "--X":
                    finalAns= finalAns- 1;
                    break;
            }

            length--;
        }

        return finalAns;
    }
}