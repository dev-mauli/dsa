// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static char nonRepeatingChar(string S)
{
    // code here
    Dictionary<char, int> charCount = new Dictionary<char, int>();
    foreach (var s in S)
    {
        if (charCount.ContainsKey(s))
        {
            charCount[s]++;
        }
        else
        {
            charCount[s] = 1;
        }
    }
    if (charCount.Values.All(x => x > 1))
    {
        return '$';
    }
    else
    {
        return charCount.FirstOrDefault(x => x.Value == 1).Key;
    }
}

nonRepeatingChar("geeksforgeeks");