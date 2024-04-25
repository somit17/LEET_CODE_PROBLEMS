public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int[] arr = new int [26];
        foreach (var eachChar in chars)
            arr[eachChar - 'a']++;
        int result = 0;
        foreach (var word in words)
        {
            int[] wordCount = new int[26];
            foreach (var eachChar in word)
                wordCount[eachChar - 'a']++;
            bool ok = true;
            for (int i = 0; i < 26; i++)
            {
                if (wordCount[i] > arr[i])
                {
                    ok = false;
                    break;
                }
            }

            if (ok) result += word.Length;
        }
        return result;
    }
}