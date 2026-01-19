// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static int search(int[] arr, int key)
{
    // Code Here
    int left = 0, right = arr.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (arr[mid] == key)
            return mid;

        // Left half is sorted
        if (arr[left] <= arr[mid])
        {
            if (key >= arr[left] && key < arr[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        // Right half is sorted
        else
        {
            if (key > arr[mid] && key <= arr[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
    }

    return -1;
}

search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);