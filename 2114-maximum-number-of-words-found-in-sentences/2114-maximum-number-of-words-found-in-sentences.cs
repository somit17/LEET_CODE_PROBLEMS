public class Solution {
    public int MostWordsFound(string[] sentences) {
        int max = 0;
        foreach (var sentence in sentences)
        {
            int currentMax = sentence.Split(" ").Length;
            if (currentMax > max)
            {
                max = currentMax;
            }
        }
        return max;
    }
}