// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int StrStr(string haystack, string needle)
{
    if (needle.Length == 0) return 0;
    int h = haystack.Length;
    int n = needle.Length;
    int j = 0;
    for (int i = 0; i < h; i++)
    {
        if (haystack[i] == needle[j])
        {
            j++;
            if (j == n)
            {
                return i - n + 1;
            }
        }
        else
        {
            i = i - j;
            j = 0;
        }
    }
    return -1;
}

StrStr("sadbutsad", "sad");

Console.WriteLine("Test");