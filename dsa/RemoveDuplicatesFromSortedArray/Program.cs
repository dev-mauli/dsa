// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

static int RemoveDuplicates(int[] nums)
{
    int left = 1;
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != nums[i - 1])
        {
            nums[left] = nums[i];
            left++;
        }
    }
    return left;
}

RemoveDuplicates(new int[] { 1, 1, 2, 2, 3, 4, 4, 5 });

Console.WriteLine("Test");