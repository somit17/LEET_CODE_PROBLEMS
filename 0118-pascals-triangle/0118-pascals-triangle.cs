public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> result = new List<IList<int>>();
        if (numRows == 0)
        {
            return result;
        }

        // 1st row
        var previousRow = new List<int>();
        previousRow.Add(1);
        result.Add(previousRow);

        for (int i = 1; i < numRows; i++)
        {
            var currentRow = new List<int>();
            int prev=0;
            foreach (var val in previousRow)
            {
                currentRow.Add(prev+val);
                prev = val;
            }
            //need to add 1 after completion
            currentRow.Add(1);
            result.Add(currentRow);
            previousRow = currentRow;
        }

        return result;
    }
}