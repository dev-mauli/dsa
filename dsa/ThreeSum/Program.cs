// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

static IList<IList<int>> ThreeSum(int[] nums)
{
    if (nums.Length < 3)
    {
        return new List<IList<int>>();
    }
    Array.Sort(nums);
    HashSet<IList<int>> result = new HashSet<IList<int>>();
    for (int i = 0; i < nums.Length - 2; i++)
    {
        if (i > 0 && nums[i] == nums[i - 1]) continue;
        int left = i + 1;
        int right = nums.Length - 1;
        while (left < right)
        {
            int sum = nums[i] + nums[left] + nums[right];
            if (sum == 0)
            {
                result.Add(new List<int> { nums[i], nums[left], nums[right] });
                while (left < right && nums[left] == nums[left + 1]) left++;
                while (left < right && nums[right] == nums[right - 1]) right--;
                left++; right--;
            }
            else if (sum < 0)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
    }
    return result.ToList();
}

ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });

Console.WriteLine("Test");
