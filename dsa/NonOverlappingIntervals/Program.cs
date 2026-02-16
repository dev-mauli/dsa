// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int minRemoval(int[][] intervals)
{
    // code here
    if (intervals.Length == 0) return 0;

    // Sort by end time
    Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

    int removals = 0;
    int lastEnd = intervals[0][1];

    for (int i = 1; i < intervals.Length; i++)
    {
        // Overlapping interval → remove it
        if (intervals[i][0] < lastEnd)
        {
            removals++;
        }
        else
        {
            // Non-overlapping → keep it
            lastEnd = intervals[i][1];
        }
    }

    return removals;
}

minRemoval(new int[][] {
    new int[] {1,2},
    new int[] {2,3},
    new int[] {3,4},
    new int[] {1,3}
});