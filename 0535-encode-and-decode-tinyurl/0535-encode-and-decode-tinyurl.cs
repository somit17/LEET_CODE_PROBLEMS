public class Codec {
public Dictionary<string, string> map = new();
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        StringBuilder sb = new();
        Random random = new();
        sb.Append((char)random.Next(0, 200));
        while (map.ContainsKey(sb.ToString()))
        {
            sb.Append((char)random.Next(0, 200));
        }
        map.Add(sb.ToString(),longUrl);
        return sb.ToString();
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
      string longUrl = string.Empty;
        map.TryGetValue(shortUrl, out longUrl);
        return longUrl;  
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));