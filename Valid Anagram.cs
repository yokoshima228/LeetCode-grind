using System.ComponentModel.Design;

public class Program
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
            return false;
        char[] arrOfS = s.ToCharArray();
        char[] arrOfT = t.ToCharArray();
        Array.Sort(arrOfS);Array.Sort(arrOfT);
        return arrOfS.SequenceEqual(arrOfT);
    }
}
