using leetcode_tasks;

namespace Leetcode;

public class Program
{
    public static void Main(string[] args)
    {
        MaxSubarray m = new();

        int x = m.MaxSubArray([-2, 1]);
        Console.WriteLine(x);
    }
}