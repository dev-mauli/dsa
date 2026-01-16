// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

static string IntToRoman(int num)
{
    Dictionary<int, string> valMap = new Dictionary<int, string>()
    {
        {1000, "M"},
        {900, "CM"},
        {500, "D"},
        {400, "CD"},
        {100, "C"},
        {90, "XC"},
        {50, "L"},
        {40, "XL"},
        {10, "X"},
        {9, "IX"},
        {5, "V"},
        {4, "IV"},
        {1, "I"}
    };
    StringBuilder roman = new StringBuilder();
    for (int i = 0; i < num; i++)
    {
        foreach (var item in valMap)
        {
            while (num >= item.Key)
            {
                roman.Append(item.Value);
                num -= item.Key;
            }
        }
    }
    return roman.ToString();
}

IntToRoman(1994);