// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> result = new Dictionary<int, int>();
    int remaningVal = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        remaningVal = target - nums[i];
        int index = 0;
        if (result.TryGetValue(remaningVal, out index))
        {
            return [index, i];
        }

        if (!result.ContainsKey(nums[i]))
        {
            result.Add(nums[i], i);
        }
    }
    return null;
}
int[] arr = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
foreach (int i in arr)
{
    Console.WriteLine(i);
}
Console.WriteLine("Test");