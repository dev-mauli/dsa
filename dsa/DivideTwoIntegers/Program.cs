Console.WriteLine("Hello, World!");

static int Divide(int dividend, int divisor)
{
    // Edge case: overflow
    if (dividend == int.MinValue && divisor == -1)
        return int.MaxValue;

    // Determine sign
    bool isNegative = (dividend < 0) ^ (divisor < 0);

    // Convert to long to prevent overflow
    long a = Math.Abs((long)dividend);
    long b = Math.Abs((long)divisor);

    int result = 0;

    // Bit manipulation (shift divisor)
    for (int i = 31; i >= 0; i--)
    {
        if ((a >> i) >= b)
        {
            result += (1 << i);
            a -= (b << i);
        }
    }

    return isNegative ? -result : result;
}

Divide(10, 3);