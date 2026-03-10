Console.WriteLine("Hello, World!");
static List<int> CountDistinct(int[] arr, int k)
{
    List<int> result = new List<int>();
    Dictionary<int, int> freq = new Dictionary<int, int>();

    // First window
    for (int i = 0; i < k; i++)
    {
        if (freq.ContainsKey(arr[i]))
            freq[arr[i]]++;
        else
            freq[arr[i]] = 1;
    }

    result.Add(freq.Count);

    // Slide window
    for (int i = k; i < arr.Length; i++)
    {
        // Remove outgoing element
        int outElem = arr[i - k];
        freq[outElem]--;

        if (freq[outElem] == 0)
            freq.Remove(outElem);

        // Add incoming element
        if (freq.ContainsKey(arr[i]))
            freq[arr[i]]++;
        else
            freq[arr[i]] = 1;

        result.Add(freq.Count);
    }

    return result;
}

CountDistinct(new int[] { 1, 2, 1, 3, 4 }, 3);