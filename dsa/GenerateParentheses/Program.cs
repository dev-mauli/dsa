// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static IList<string> GenerateParenthesis(int n)
{
    int openParen = n;
    int closeParen = n;
    List<string> result = new List<string>();
    void Backtrack(string current, int open, int close)
    {
        if (current.Length == n * 2)
        {
            result.Add(current);
            return;
        }
        if (open > 0)
        {
            Backtrack(current + "(", open - 1, close);
        }
        if (close > open)
        {
            Backtrack(current + ")", open, close - 1);
        }
    }
    Backtrack("", openParen, closeParen);
    return result;
}

GenerateParenthesis(3);