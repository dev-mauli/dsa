Console.WriteLine("Hello, World!");


static List<int> SubarraySum(int[] arr, int target)
{
    // Code Here
    int left = 0;
    int sum = 0;

    for (int right = 0; right < arr.Length; right++)
    {
        sum += arr[right];

        while (sum > target && left <= right)
        {
            sum -= arr[left];
            left++;
        }

        if (sum == target)
        {
            return arr.Skip(left).Take(right - left + 1).ToList();
        }
    }

    return new List<int>();
}

SubarraySum(new int[] { 1, 2, 3, 7, 5 }, 12);