public class Solution {
    public string DefangIPaddr(string address) {
        StringBuilder sb = new();
        for (int i = 0; i < address.Length; i++)
        {
            if (address[i] == '.')
                sb.Append("[.]");
            else
                sb.Append(address[i]);
        }
        return sb.ToString();
    }
}