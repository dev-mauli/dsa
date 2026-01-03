// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
    int[] mergedArr = nums1.Concat(nums2).ToArray();
    int left = 0;
    int right = mergedArr.Length - 1;
    while (left < right)
    {
        left++;
        right--;
    }
    double median = (double)(mergedArr[left] + mergedArr[right]) / 2;
    return median;
}

FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 });

Console.WriteLine("Test");