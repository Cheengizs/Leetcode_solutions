namespace Leetcode;

public class RestoreIP
{
    public IList<string> RestoreIpAddresses(string s)
    {
        List<string> res = new();

        if (s.Length < 4 || s.Length > 12) return res;
        for (int i = 1; i < 4; i++)
        {
            for (int j = i + 1; j < i + 4; j++)
            {
                for (int k = j + 1; k < j + 4; k++)
                {
                    if(k >= s.Length) continue;
                    string str1 = s.Substring(0, i);
                    string str2 = s.Substring(i, j - i);
                    string str3 = s.Substring(j, k - j);
                    string str4 = s.Substring(k);

                    if (CheckIP(str1, str2, str3, str4))
                    {
                        res.Add($"{str1}.{str2}.{str3}.{str4}");
                    }
                }
            }
        }

        return res;
    }

    public bool CheckIP(string str1, string str2, string str3, string str4)
    {
        return CheckOneNum(str1) && CheckOneNum(str2) && CheckOneNum(str3) && CheckOneNum(str4);
    }

    public bool CheckOneNum(string str1)
    {
        if (str1.Length > 0 && str1.Length < 4)
        {
            int num;
            int.TryParse(str1, out num);
            if (num >= 0 && num <= 255)
            {
                if (num.ToString().Length == str1.Length)
                {
                    return true;
                }
            }
        }

        return false;
    }
}