// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static void RotateArr(int[] arr, int d)
{
    // Code Here
    int n = arr.Length;
    d = d % n;

    ReverseArr(arr, 0, d - 1);
    ReverseArr(arr, d, n - 1);
    ReverseArr(arr, 0, n - 1);
}

static void ReverseArr(int[] arr, int left, int right)
{
    while (left < right)
    {
        (arr[left], arr[right]) = (arr[right], arr[left]);
        left++;
        right--;
    }
}

RotateArr(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);

Console.WriteLine("Test");