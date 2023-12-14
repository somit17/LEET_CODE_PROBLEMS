public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        List<string> finalList = new();
        foreach (var item in items)
        {
            if (ruleKey.Equals("type"))
            {
                finalList.Add(item[0]);
            }
            else if (ruleKey.Equals("color"))
            {
                finalList.Add(item[1]);
            }
            else
            {
                finalList.Add(item[2]);
            }
        }

      return finalList.Where(x => x.Equals(ruleValue)).Count();
    }
}