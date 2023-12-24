public class Solution {
    public IList<string> CellsInRange(string s) {
        string[] cellRange = s.Split(new char[] { ':' });
        string startRange = cellRange[0];
        string endRange = cellRange[1];
        char colStart = startRange.ToCharArray()[0];
        char colEnd = endRange.ToCharArray()[0];
        int rowStart = startRange.ToCharArray()[1] - '0';
        int rowEnd = endRange.ToCharArray()[1] - '0';
        List<string> finalList = new();
        for (char c =colStart; c <= colEnd; c++)
        {
            for (int i = rowStart; i <= rowEnd; i++)
            {
                finalList.Add(c.ToString() + (i));
            }
        }


        return finalList; 
    }
}