namespace Leetcode;

public class equalize_frequency
{
    public bool EqualFrequency(string word)
    {
        int[] freq = new int['z' - 'a' + 1];

        foreach (var elem in word)
        {
            freq[elem - 'a']++;
        }

        for (int i = 0; i < freq.Length; i++)
        {
            if(freq[i] == 0) continue;
            freq[i]--;
            if (CheckEquality(freq)) return true;
            freq[i]++;
        }

        return false;
    }

    public bool CheckEquality(int[] arr)
    {
        bool equal = true;

        int i = 0;
        while (i < arr.Length && arr[i] == 0)
            i++;
        
        var elem = arr[i];
        while (equal && i < arr.Length)
        {
            if (arr[i] == 0)
            {
                i++;
                continue;
            }

            if (arr[i] != elem) equal = false;
            i++;
        }
        
        return equal;
    }
}