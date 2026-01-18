// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

static IList<string> LetterCombinations(string digits)
{
    Dictionary<char, string> phoneMap = new Dictionary<char, string>
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }
    };
    List<string> result = new List<string>();
    if (string.IsNullOrEmpty(digits))
    {
        return result;
    }
    void Backtrack(int index, StringBuilder path)
    {
        if (index == digits.Length)
        {
            result.Add(path.ToString());
            return;
        }
        char digit = digits[index];
        string letters = phoneMap[digit];
        foreach (char letter in letters)
        {
            path.Append(letter);
            Backtrack(index + 1, path);
            path.Length--; // backtrack
        }
    }
    if (!string.IsNullOrEmpty(digits))
        Backtrack(0, new StringBuilder());
    return result;
}

LetterCombinations("23");