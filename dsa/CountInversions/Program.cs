// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int InversionCount(int[] arr)
{
    int[] temp = new int[arr.Length];
    return MergeSort(arr, temp, 0, arr.Length - 1);
}

static int MergeSort(int[] arr, int[] temp, int left, int right)
{
    int invCount = 0;

    if (left < right)
    {
        int mid = (left + right) / 2;

        invCount += MergeSort(arr, temp, left, mid);
        invCount += MergeSort(arr, temp, mid + 1, right);
        invCount += Merge(arr, temp, left, mid, right);
    }

    return invCount;
}

static int Merge(int[] arr, int[] temp, int left, int mid, int right)
{
    int i = left;     // left subarray
    int j = mid + 1;  // right subarray
    int k = left;
    int invCount = 0;

    while (i <= mid && j <= right)
    {
        if (arr[i] <= arr[j])
        {
            temp[k++] = arr[i++];
        }
        else
        {
            temp[k++] = arr[j++];
            invCount += (mid - i + 1);
        }
    }

    while (i <= mid)
        temp[k++] = arr[i++];

    while (j <= right)
        temp[k++] = arr[j++];

    for (i = left; i <= right; i++)
        arr[i] = temp[i];

    return invCount;
}

InversionCount(new int[] { 2, 4, 1, 3, 5 });