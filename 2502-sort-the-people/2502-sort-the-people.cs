public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
      SortedDictionary<int,string> hastable = new();
        int len = heights.Length ;
        for (int i = 0; i < len; i++)
        {
            hastable.Add(heights[i],names[i]);    
        };
        var reversedData =  hastable.OrderByDescending(x=>x.Key);
        List<string> sortedPeople = new();
        foreach (var data in reversedData)
        {
            sortedPeople.Add(data.Value);
        }
        return sortedPeople.ToArray(); 
    }
}