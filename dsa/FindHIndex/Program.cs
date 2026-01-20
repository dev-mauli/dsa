// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int hIndex(int[] citations)
{
    Array.Sort(citations);
    int n = citations.Length;

    for (int i = 0; i < n; i++)
    {
        int papers = n - i;
        if (citations[i] >= papers)
        {
            return papers;
        }
    }
    return 0;
}

hIndex(new int[] { 3, 0, 5, 3, 0 });