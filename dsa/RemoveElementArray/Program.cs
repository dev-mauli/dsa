// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int RemoveElement(int[] nums, int val)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            nums[count] = nums[i];
            count++;
        }
    }
    return count;
}

RemoveElement(new int[] { 3, 2, 2, 3 }, 3);

Console.WriteLine("Test");