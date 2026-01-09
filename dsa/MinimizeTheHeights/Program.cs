// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int getMinDiff(int[] arr, int k)
{
    // code here
    int result = 0;
    int n = arr.Length;
    Array.Sort(arr);
    result = arr[n - 1] - arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] - k < 0) { continue; }
        int min = Math.Min(arr[0] + k, arr[i] - k);
        int max = Math.Max(arr[i - 1] + k, arr[n - 1] - k);
        result = Math.Min(result, max - min);
    }
    return result;
}

getMinDiff(new int[] { 1, 5, 8, 10 }, 2);

Console.WriteLine("Test");