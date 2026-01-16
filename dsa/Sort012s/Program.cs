// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void sort012(int[] arr)
{
    // code here
    int n = arr.Length;
    int low = 0;
    int high = arr.Length - 1;
    int mid = 0;
    while (mid <= high)
    {
        if (arr[mid] == 0)
        {
            (arr[mid], arr[low]) = (arr[low], arr[mid]);
            low++;
            mid++;
        }
        else if (arr[mid] == 1)
        {
            mid++;
        }
        else
        {
            (arr[mid], arr[high]) = (arr[high], arr[mid]);
            high--;
        }
    }
}

sort012(new int[] { 0, 1, 2, 0, 1, 2 });