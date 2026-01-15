// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int maxProduct(int[] arr)
{
    // code here
    int n = arr.Length;
    int maxSoFar = arr[0];
    int maxEndingHere = arr[0];
    int minEndingHere = arr[0];
    for (int i = 1; i < n; i++)
    {
        if (arr[i] < 0)
        {
            (maxEndingHere, minEndingHere) = (minEndingHere, maxEndingHere);
        }
        maxEndingHere = Math.Max(arr[i], maxEndingHere * arr[i]);
        minEndingHere = Math.Min(arr[i], minEndingHere * arr[i]);
        maxSoFar = Math.Max(maxSoFar, maxEndingHere);
    }
    return maxSoFar;
}

maxProduct(new int[] { -2, 6, -3, -10, 0, 2 });