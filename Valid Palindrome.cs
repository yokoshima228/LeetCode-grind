using System.ComponentModel.Design;
using System.Text;

public class Program
{
    public bool IsPalindrome(string s)
    {
        StringBuilder newWord = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
                newWord.Append(char.ToLower(s[i]));
        }

        string reversedWord = new string(newWord.ToString().Reverse().ToArray());

        return reversedWord == newWord.ToString();
    }
}
