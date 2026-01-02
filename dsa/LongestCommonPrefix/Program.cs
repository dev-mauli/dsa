// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

static string LongestCommonPrefix(string[] strs)
{
    StringBuilder result = new StringBuilder();

    Array.Sort(strs);

    char[] first = strs[0].ToCharArray();
    char[] last = strs[strs.Length - 1].ToCharArray();

    for (int i = 0; i < first.Length; i++)
    {
        if (first[i] == last[i])
        {
            result.Append(first[i]);
        }
        else
        {
            break;
        }
    }

    return result.ToString();
}

LongestCommonPrefix(new string[] { "flower", "flow", "flight" });

Console.WriteLine("Test");