// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void reverseArray(int[] arr)
{
    // code here
    int left = 0;
    int right = arr.Length - 1;
    while (left < right)
    {
        (arr[left],arr[right]) = (arr[right], arr[left]);
        left++;
        right--;
    }
}

reverseArray(new int[] { 12, 35, 1, 10, 34, 1 });

Console.WriteLine("Test");