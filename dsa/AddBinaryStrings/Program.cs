// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

static string AddBinary(string a, string b)
{
    int i = a.Length - 1;
    int j = b.Length - 1;
    int carry = 0;

    StringBuilder result = new StringBuilder();

    while (i >= 0 || j >= 0 || carry > 0)
    {
        int sum = carry;

        if (i >= 0) sum += a[i--] - '0';
        if (j >= 0) sum += b[j--] - '0';

        result.Insert(0, sum % 2);
        carry = sum / 2;
    }

    return result.ToString();
}

AddBinary("1010", "1011");