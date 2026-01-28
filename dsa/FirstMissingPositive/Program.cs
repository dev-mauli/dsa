// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int missingNumber(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n; i++)
    {
        while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
        {
            (arr[i], arr[arr[i] - 1]) = (arr[arr[i] - 1], arr[i]);
        }
    }
    for (int i = 0; i < n; i++)
    {
        if (arr[i] != i + 1)
            return i + 1;
    }
    return n + 1;
}

missingNumber(new int[] { 2, -3, 4, 1, 1, 7 });