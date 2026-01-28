// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int[] SearchRange(int[] nums, int target)
{
    int[] result = new int[] { -1, -1 };

    result[0] = FindFirst(nums, target);
    if (result[0] == -1) return result; // target not found

    result[1] = FindLast(nums, target);
    return result;
}

static int FindFirst(int[] nums, int target)
{
    int left = 0, right = nums.Length - 1;
    int index = -1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (nums[mid] == target)
        {
            index = mid;
            right = mid - 1; // move left
        }
        else if (nums[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    return index;
}

static int FindLast(int[] nums, int target)
{
    int left = 0, right = nums.Length - 1;
    int index = -1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (nums[mid] == target)
        {
            index = mid;
            left = mid + 1; // move right
        }
        else if (nums[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    return index;
}


SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8);