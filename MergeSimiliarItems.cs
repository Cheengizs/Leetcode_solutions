using System.Collections;

namespace Leetcode;

public class MergeSimiliarItems
{
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) {
        List<IList<int>> res = new List<IList<int>>();
        foreach (var elem in items1)
        {
            res.Add(new List<int>(elem));
        }

        foreach (var coll in items2)
        {
            bool isFound = false;
            int i = 0;
            while (i < res.Count && !isFound)
            {
                if (coll[0] == res[i][0])
                {
                    isFound = true;
                }

                if (!isFound) i++;
            }
            if(isFound) res[i][1] += coll[1];
            else res.Append( new List<int>(coll));
        }

        res.Sort((a, b) => a[0] - b[0]);
        return res;
    }
}