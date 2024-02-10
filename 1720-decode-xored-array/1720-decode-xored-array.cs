public class Solution {
    public int[] Decode(int[] encoded, int first) {
      List<int> decodedArray = new List<int>();
        decodedArray.Add(first);

        for (int i = 0; i < encoded.Length; i++)
        {
            int xorResult = decodedArray[i] ^ encoded[i];
            decodedArray.Add(xorResult);
        }

        return decodedArray.ToArray();  
    }
}