public class Solution {
    public string GetHappyString(int n, int k)
    {
        List<string> happyStrings = new List<string>();
        GenerateHappyStrings("", n, happyStrings);
        happyStrings = happyStrings.OrderBy(s => s).ToList();
        if (k > happyStrings.Count)
            return "";
        else
            return happyStrings[k - 1];
    }

    void GenerateHappyStrings(string current, int n, List<string> result)
    {
        if (current.Length == n)
        {
            result.Add(current);
            return;
        }

        foreach (var ch in "abc")
        {
            if (current.Length == 0 || current[current.Length - 1] != ch)
            {
                GenerateHappyStrings(current + ch, n, result);
            }
        }
    }
}