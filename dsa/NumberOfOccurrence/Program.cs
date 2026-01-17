// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static int countFreq(int[] arr, int target)
{
    // code here
    int left = 0;
    int right = arr.Length - 1;
    int count = 0;
    while (left <= right)
    {
        if (left == right)
        {
            if (arr[left] == target)
                count++;
        }
        else
        {
            if (arr[left] == target)
                count++;
            if (arr[right] == target)
                count++;
        }
        left++;
        right--;
    }
    return count;
}

countFreq(new int[] { 1, 1, 2, 2, 2, 2, 3 }, 2);