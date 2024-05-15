public class Solution {
    string res = "";

    public string FindDifferentBinaryString(string[] nums)
    {
        HashSet<string> set = new();
        foreach (var num in nums)
            set.Add(num);
        return solve("", nums, set);
    }

    string solve(string cur, string[] nums, HashSet<string> set)
    {
        if (cur.Length == nums.Length)
        {
            if (!set.Contains(cur)) // res
                res = cur;
            return res;
        }

        if (res == "")
            solve(cur + "0", nums, set);
        if (res == "")
            solve(cur + "1", nums, set);
        return res;
    }
}