public class Program
{
    public static void Main(string[] args)
    {

    }
    public int MajorityElement(int[] nums)
    {
        var list = new Dictionary<int, int>() { };
        foreach (var num in nums)
        {
            if (!list.ContainsKey(num))
            {
                list[num] = 1;
            }
            else
            {
                list[num]++;
            }
        }

        foreach (var item in list)
        {
            if (item.Value > nums.Length / 2)
            {
                return item.Key;
            }
        }
        return -1;
    }
}
