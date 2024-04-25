public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        List<string> operations = new();
        int stream = 1;
        int index = 0;

        while (index < target.Length && stream <= n)
        {
            operations.Add("Push");
            if (stream == target[index])
                index++;
            else
                operations.Add("Pop");
            stream++;
        }

        return operations;
    }
}