// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int maxCircularSum(int[] arr)
{
    // code here
    int globalMax = arr[0], globalMin = arr[0];
    int currentMax = 0, currentMin = 0, total = 0;
    foreach (var n in arr)
    {
        currentMax = Math.Max(currentMax + n, n);
        currentMin = Math.Min(currentMin + n, n);

        total += n;

        globalMax = Math.Max(globalMax, currentMax);
        globalMin = Math.Min(globalMin, currentMin);
    }
    if (globalMax < 0)
        return globalMax;

    return Math.Max(globalMax, total - globalMin);
}

maxCircularSum(new int[] { 8, -8, 9, -9, 10, -11, 12 });