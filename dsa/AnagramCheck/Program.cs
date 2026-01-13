// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static bool areAnagrams(string s1, string s2)
{
    // code here
    Dictionary<char, int> charCount = new Dictionary<char, int>();
    foreach (char c in s1)
    {
        if (charCount.ContainsKey(c))
            charCount[c]++;
        else
            charCount[c] = 1;
    }
    foreach (char c in s2)
    {
        if (charCount.ContainsKey(c))
        {
            charCount[c]--;
            if (charCount[c] < 0)
                return false;
        }
        else
        {
            return false;
        }
    }
    return true;
}

areAnagrams("listen", "silent");

Console.WriteLine("Test");