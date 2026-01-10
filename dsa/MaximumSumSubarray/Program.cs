// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int maxSubarraySum(int[] arr)
{
    // code here
    int result = arr[0];
    int maxEnding = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        maxEnding = Math.Max(arr[i], maxEnding + arr[i]);
        result = Math.Max(result, maxEnding);
    }
    return result;
}

maxSubarraySum(new int[] { 2, 3, -8, 7, -1, 2, 3 });

Console.WriteLine("Test");