// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void pushZerosToEnd(int[] nums)
{
    int counter = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            nums[counter++] = nums[i];
        }
    }
    while (counter < nums.Length)
    {
        nums[counter++] = 0;
    }
}

static void pushZerosToEndSwap(int[] nums)
{
    int counter = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            (nums[i], nums[counter]) = (nums[counter], nums[i]);
            counter++;
        }
    }
}
pushZerosToEndSwap(new int[] { 0, 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 });
Console.WriteLine("Test");