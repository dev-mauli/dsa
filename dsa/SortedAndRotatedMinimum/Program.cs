// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int findMin(int[] nums)
{
    int left = 0;
    int right = nums.Length - 1;
    while (left < right)
    {
        int mid = left + (right - left) / 2;
        if (nums[mid] > nums[right])
        {
            left = mid + 1;
        }
        else
        {
            right = mid;
        }
    }
    return nums[left];
}

findMin(new int[] { 3, 4, 5, 1, 2 });