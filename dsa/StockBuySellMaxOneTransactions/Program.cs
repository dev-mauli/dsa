// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int MaximumProfit(int[] prices)
{
    // code here
    int buyPrice = prices[0], currentProfit = 0, maxProfit = 0;
    for (int i = 1; i < prices.Length; i++)
    {
        if (prices[i] < buyPrice)
        {
            buyPrice = prices[i];
            currentProfit = prices[i] - buyPrice;
        }
        else if (prices[i] - buyPrice > currentProfit)
        {
            currentProfit = prices[i] - buyPrice;
        }
        if (currentProfit > maxProfit)
        {
            maxProfit = currentProfit;
        }
    }
    return maxProfit;
}

MaximumProfit(new int[] { 1, 3, 6, 9, 11 });

Console.WriteLine("Test");