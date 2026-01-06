// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("Hello, World!");

static List<int> findMajority(int[] arr)
{
    // Code here
    List<int> result = new List<int>();
    int n = arr.Length / 3;
    Dictionary<int, int> countMap = new Dictionary<int, int>();
    foreach (int num in arr)
    {
        if (countMap.ContainsKey(num))
        {
            countMap[num]++;
            if (countMap[num] == n + 1)
            {
                result.Add(num);
            }
        }
        else
        {
            countMap[num] = 1;
        }
    }
    return result.Order().ToList();
}

findMajority(new int[] { 2, 2, 3, 1, 3, 2, 1, 1 });

Console.WriteLine("Test");