Console.WriteLine("Hello, World!");

static int countTriangles(int[] arr)
{
    // code here
    int count = 0;
    Array.Sort(arr);

    for (int i = 2; i < arr.Length; i++)
    {
        int left = 0;
        int right = i - 1;

        while (left < right)
        {
            if (arr[left] + arr[right] > arr[i])
            {
                count += right - left;
                right--;
            }
            else
            {
                left++;
            }
        }
    }
    return count;
}

countTriangles(new int[] { 4, 6, 3, 7 });