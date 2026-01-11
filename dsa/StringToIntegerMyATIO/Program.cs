// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int myAtoi(string s)
{
    // code here
    int sign = 1;
    int result = 0;
    int index = 0;

    while (index < s.Length && s[index] == ' ')
    {
        index++;
    }

    if (index < s.Length && (s[index] == '+' || s[index] == '-'))
    {
        sign = s[index] == '-' ? -1 : 1;
        index++;
    }

    while (index < s.Length && char.IsDigit(s[index]))
    {
        int digit = s[index] - '0';
        if (result > (int.MaxValue - digit) / 10)
        {
            return sign == 1 ? int.MaxValue : int.MinValue;
        }
        result = result * 10 + digit;
        index++;
    }
    return result * sign;
}

myAtoi("-123");