// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int FindEquilibriumPoint(int[] arr)
{
    int totalSum = 0;
    foreach (int num in arr)
    {
        totalSum += num;
    }
    int leftSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (leftSum == totalSum - leftSum - arr[i])
        {
            return i; // Return the index of the equilibrium point
        }
        leftSum += arr[i];
    }
    return -1; // No equilibrium point found
}

FindEquilibriumPoint(new int[] { -7, 1, 5, 2, -4, 3, 0 });