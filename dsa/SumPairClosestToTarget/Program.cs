Console.WriteLine("Hello, World!");

static List<int> sumClosest(int[] arr, int target)
{
    // code here
    Array.Sort(arr);
    int left = 0;
    int right = arr.Length - 1;
    int minDifference = int.MaxValue;
    List<int> result = new List<int>();
    while (left < right)
    {
        int sum = arr[left] + arr[right];
        int diff = Math.Abs(sum - target);
        if (diff < minDifference)
        {
            minDifference = diff;
            result.Clear();
            result.Add(arr[left]);
            result.Add(arr[right]);
        }

        if (sum < target)
        {
            left++;
        }
        else if (sum > target)
        {
            right--;
        }
        else
        {
            return result;
        }
    }
    return result;
}

sumClosest(new int[] { 5, 2, 7, 1, 4 }, 10); // [4, 5]