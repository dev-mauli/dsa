// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int peakElement(int[] arr)
{
    // code here
    int n = arr.Length;
    int low = 0, high = n - 1;

    while (low < high)
    {
        int mid = low + (high - low) / 2;

        if (arr[mid] < arr[mid + 1])
            low = mid + 1;
        else
            high = mid;
    }

    return low;
}

peakElement(new int[] { 1, 2, 4, 5, 7, 8, 3 });