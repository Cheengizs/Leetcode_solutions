using System.Data;

namespace Leetcode;

public class ConvertMatrixTo2DWithCondition
{
    public IList<IList<int>> FindMatrix(int[] nums) {
        List<IList<int>> res = new();
        LinkedList<int> temp = new(nums);

        while (temp.Count != 0)
        {
            List<int> currRow = new();
            HashSet<int> visited = new();
            
            foreach (var elem in temp)
            {
                if (!visited.Contains(elem))
                {
                    visited.Add(elem);
                    currRow.Add(elem);
                }
            }

            foreach (var elem in currRow)
            {
                temp.Remove(elem);
            }
            res.Add(currRow);
        }
        
        return res;
    }
}