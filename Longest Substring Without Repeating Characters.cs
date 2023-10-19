using System.ComponentModel.Design;

public class Program
{
    public int LengthOfLongestSubstring(string s)
    {
        int left = 0, right = 0, maxlen = 0;
        HashSet<char> strings = new HashSet<char>()
        {
        };
        while(right < s.Length)
        {
            if (!strings.Contains(s[right]))
            {
                strings.Add(s[right]);
                maxlen = Math.Max(maxlen, right - left + 1);
                right++;
            }
            else
            {
                strings.Remove(s[left]);
                left++;
            }
        }
        return maxlen;
    }
}
