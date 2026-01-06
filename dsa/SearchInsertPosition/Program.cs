// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int SearchInsert(int[] nums, int target)
{
    int left = 0, right = nums.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (nums[mid] == target)
            return mid;
        else if (nums[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return left;
}

SearchInsert(new int[] { 1, 3, 5, 6 }, 2);

Console.WriteLine("Test");