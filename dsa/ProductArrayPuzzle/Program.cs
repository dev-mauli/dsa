// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int[] productExceptSelf(int[] arr)
{
    // code here
    int n = arr.Length;
    int[] res = new int[n];

    // Step 1: Left products
    res[0] = 1;
    for (int i = 1; i < n; i++)
    {
        res[i] = res[i - 1] * arr[i - 1];
    }

    // Step 2: Right products
    int rightProduct = 1;
    for (int i = n - 1; i >= 0; i--)
    {
        res[i] = res[i] * rightProduct;
        rightProduct *= arr[i];
    }

    return res;
}

productExceptSelf(new int[] { 10, 3, 5, 6, 2 });