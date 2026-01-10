// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int LengthOfLongestSubstring(string s)
{
    int n = s.Length;
    int maxLength = 0;
    Dictionary<char, int> map = new Dictionary<char, int>();
    for (int left = 0, right = 0; right < n; right++)
    {
        if (map.ContainsKey(s[right]))
        {
            left = Math.Max(map[s[right]] + 1, left);
        }
        map[s[right]] = right;
        maxLength = Math.Max(maxLength, right - left + 1);
    }
    return maxLength;
}

LengthOfLongestSubstring("abcabcbb");