using System.Text;

namespace Leetcode;

public class AddBinaryCl
{
    public string AddBinary(string a, string b)
    {
        StringBuilder sb = new();
        if (a.Length > b.Length)
        {
            b = b.Insert(0, new string('0', a.Length - b.Length));
        }
        else if (a.Length < b.Length)
        {
            a = a.Insert(0, new string('0', b.Length - a.Length));
        }

        int isUp = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            int x = int.Parse(a[i].ToString());
            int y = int.Parse(b[i].ToString());
            sb.Insert(0, (x + y + isUp) % 2);
            isUp = (x + y + isUp) / 2;
        }

        if (isUp == 1) sb.Insert(0, '1');
        return sb.ToString();
    }
}