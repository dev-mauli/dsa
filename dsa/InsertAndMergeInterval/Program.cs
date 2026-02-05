// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static List<int[]> insertInterval(int[][] intervals, int[] newInterval)
{
    // code here
    List<int[]> result = new List<int[]>();
    int i = 0;
    int n = intervals.Length;

    // Add all intervals before newInterval
    while (i < n && intervals[i][1] < newInterval[0])
    {
        result.Add(intervals[i]);
        i++;
    }

    while (i < n && intervals[i][0] <= newInterval[1])
    {
        newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
        newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
        i++;
    }
    result.Add(newInterval);

    while (i < n)
    {
        result.Add(intervals[i]);
        i++;
    }
    return result;
}

insertInterval(new int[][]
{
    new int[] {1, 3},
    new int[] {4, 5},
    new int[] {6, 7},
    new int[] {8, 10},
}, new int[] { 5, 6 });