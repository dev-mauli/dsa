// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int[] GetConcatenation(int[] nums)
{
    int[] result = new int[nums.Length * 2];
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = nums[i];
        result[i + nums.Length] = nums[i];
    }
    return result;
}

GetConcatenation(new int[] { 1, 2, 3, 4 });

Console.WriteLine("Test");