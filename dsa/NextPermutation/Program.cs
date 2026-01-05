// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void nextPermutation(int[] arr)
{
    // code here
    int n = arr.Length;
    int pivot = -1;
    for (int i = n - 2; i >= 0; i--)
    {
        if (arr[i] < arr[i + 1])
        {
            pivot = i;
            break;
        }
    }
    if (pivot == -1)
    {
        Array.Reverse(arr);
        return;
    }
    for (int i = n - 1; i > pivot; i--)
    {
        if (arr[i] > arr[pivot])
        {
            (arr[i], arr[pivot]) = (arr[pivot], arr[i]);
            break;
        }
    }
    int left = pivot + 1;
    int right = n - 1;
    while (left < right)
    {
        (arr[left], arr[right]) = (arr[right], arr[left]);
        left++;
        right--;
    }
}

nextPermutation(new int[] { 2, 4, 1, 7, 5, 0 });

Console.WriteLine("Test");