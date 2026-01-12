// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static string LongestPalindrome(string s)
{
    if (string.IsNullOrEmpty(s) || s.Length < 1) return "";
    int start = 0, end = 0;
    for (int i = 0; i < s.Length; i++)
    {
        int len1 = ExpandAroundCenter(s, i, i);
        int len2 = ExpandAroundCenter(s, i, i + 1);
        int len = Math.Max(len1, len2);
        if (len > end - start)
        {
            start = i - (len - 1) / 2;
            end = i + len / 2;
        }
    }
    return s.Substring(start, end - start + 1);
}

static int ExpandAroundCenter(string s, int i1, int i2)
{
    int left = i1, right = i2;
    while (left >= 0 && right < s.Length && s[left] == s[right])
    {
        left--;
        right++;
    }
    return right - left - 1;
}

LongestPalindrome("babad");