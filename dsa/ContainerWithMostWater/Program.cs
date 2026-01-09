// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int MaxArea(int[] height)
{
    int left = 0;
    int right = height.Length - 1;
    int maxArea = 0;
    while (left < right)
    {
        int width = right - left;
        int minHeight = Math.Min(height[left], height[right]);
        int area = width * minHeight;

        maxArea = Math.Max(maxArea, area);

        if (height[left] < height[right])
            left++;
        else
            right--;
    }
    return maxArea;
}

MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });

Console.WriteLine("Test");