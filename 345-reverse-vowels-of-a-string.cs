public class Solution
{
    private static HashSet<char> VOWELS = new()
    {
        'a', 'e', 'i', 'o', 'u',
        'A', 'E', 'I', 'O', 'U'
    };

    public string ReverseVowels(string s)
    {
        var letters = s.ToCharArray();
        var vowels = new Stack<char>();
        foreach (var ch in letters)
            if (VOWELS.Contains(ch))
                vowels.Push(ch);
        for (int i = 0; i < letters.Length; i++)
            if (VOWELS.Contains(letters[i]))
                letters[i] = vowels.Pop();
        return new string(letters);
    }
}
