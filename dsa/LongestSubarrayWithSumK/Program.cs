// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


static int longestSubarray(int[] arr, int k)
{
    // code here
    int n = arr.Length;
    Dictionary<int, int> prefixSumIndices = new Dictionary<int, int>();
    int result = 0;
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += arr[i];
        
        if (sum == k)
        {
            result = i + 1;
        }
        else if (prefixSumIndices.ContainsKey(sum - k))
        {
            result = Math.Max(result, i - prefixSumIndices[sum - k]);
        }

        if (!prefixSumIndices.ContainsKey(sum))
        {
            prefixSumIndices[sum] = i;
        }
    }
    return result;
}

longestSubarray(new int[] { 10, 5, 2, 7, 1, -10 }, 15);