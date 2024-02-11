public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
        List<string> splittedArray = new();
        foreach (var eachWord in words)
        {
            string[] res= eachWord.Split(separator);
            splittedArray.AddRange(res.Where(x=>!string.IsNullOrEmpty(x)));
        }

        return splittedArray;
    }
}