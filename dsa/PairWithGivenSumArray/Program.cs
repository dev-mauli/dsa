Console.WriteLine("Hello, World!");


static int countPairs(int[] arr, int target)
{
    // Complete the function
    int count = 0;
    int left = 0;
    int right = arr.Length - 1;

    while (left < right)
    {
        int sum = arr[left] + arr[right];

        if (sum > target)
        {
            right--;
        }
        else if (sum < target)
        {
            left++;
        }
        else
        {
            // Case when both elements are same
            if (arr[left] == arr[right])
            {
                int n = right - left + 1;
                count += (n * (n - 1)) / 2;
                break;
            }

            // Count duplicates on left
            int leftCount = 1;
            while (left + 1 < right && arr[left] == arr[left + 1])
            {
                leftCount++;
                left++;
            }

            // Count duplicates on right
            int rightCount = 1;
            while (right - 1 > left && arr[right] == arr[right - 1])
            {
                rightCount++;
                right--;
            }

            count += leftCount * rightCount;

            left++;
            right--;
        }
    }
    return count;
}

countPairs(new int[] { -1, 1, 5, 5, 7 }, 6);