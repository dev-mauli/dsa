// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int MaximumProfit(int[] prices)
{
    int maxProfit = 0;
    for (int i = 1; i < prices.Length; i++)
    {
        if (prices[i] > prices[i - 1])
        {
            maxProfit = prices[i] - prices[i - 1];
        }
    }
    return maxProfit;
}

MaximumProfit(new int[] { 100, 180, 260, 310, 40, 535, 695 });

Console.WriteLine("Test");