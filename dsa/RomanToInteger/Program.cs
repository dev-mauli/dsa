// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

static int RomanToInt(string s)
{
    Dictionary<char, int> valMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    int total = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (i + 1 < s.Length && valMap[s[i]] < valMap[s[i + 1]])
        {
            total -= valMap[s[i]];
        }
        else
        {
            total += valMap[s[i]];
        }
    }
    return total;
}

RomanToInt("MCMXCIV");