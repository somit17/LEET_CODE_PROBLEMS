public class Solution {
 private IList<IList<int>> combinations = new List<IList<int>>();
    private IList<int> currCombination = new List<int>();

    public IList<IList<int>> Combine(int n, int k)
    {
        CombinationsHelper(1, currCombination, combinations, n, k);
        return combinations;
    }

    public void CombinationsHelper(int i, IList<int> currCombination, IList<IList<int>> combinations, int n, int k)
    {
        if (currCombination.Count == k)
        {
            combinations.Add(new List<int>(this.currCombination));
            return;
        }

        if (i > n)
        {
            return;
        }

        for (int j = i; j < n + 1; j++)
        {
            this.currCombination.Add(j);
            CombinationsHelper(j + 1, this.currCombination, combinations, n, k);
            this.currCombination.Remove(j);
        }
    }
}