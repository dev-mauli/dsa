// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static List<int[]> mergeOverlap(int[][] arr)
{
    // code here
    Array.Sort(arr, (a, b) => a[0].CompareTo(b[0]));
    List<int[]> result = new List<int[]>();
    result.Add(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        int[] last = result[result.Count - 1];
        int[] current = arr[i];
        if (current[0] <= last[1])
        {
            last[1] = Math.Max(last[1], current[1]);
        }
        else
        {
            result.Add(current);
        }
    }
    return result;
}

mergeOverlap(new int[][]
{
    new int[] {1,3},
    new int[] {2,4},
    new int[] {6,8},
    new int[] {9,10}
});