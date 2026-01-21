// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int LengthOfLastWord(string s)
{
    string oGs = s.TrimEnd();
    string[] words = oGs.Split(' ');
    int length = words[words.Length - 1].Length;
    return length;
}

LengthOfLastWord("   fly me   to   the moon  ");