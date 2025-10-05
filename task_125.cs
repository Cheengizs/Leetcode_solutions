using System.Text;

namespace Task_125;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        string normal = GetNormalString(s);
        if (normal == new string(normal.Reverse().ToArray()))
        {
            Dictionary<int,bool> x = new Dictionary<int,bool>();
            foreach (var elem in x)
            {
                    
            }
            return true;
        }

        Console.WriteLine(normal.Reverse());
        return false;
    }

    public string GetNormalString(string s)
    {
        StringBuilder sb = new();
        foreach (var elem in s)
        {
            if (char.IsLetterOrDigit(elem))
            {
                sb.Append(char.ToLower(elem));
            }
        }

        return sb.ToString();
    }
}