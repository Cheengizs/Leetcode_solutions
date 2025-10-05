namespace Leetcode;

public class GroupPeople
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        Dictionary<int, List<int>> dict = new();

        for (int i = 0; i < groupSizes.Length; i++)
        {
            if (!dict.ContainsKey(groupSizes[i]))
            {
                dict.Add(groupSizes[i], new List<int>() { i });
            }
            else
            {
                dict[groupSizes[i]].Add(i);
            }
        }
        List<IList<int>> result = new();

        while (dict.Count != 0)
        {
            var keys = dict.Keys.ToList(); 
            var key = keys[0];
            List<int> temp = new(key);
            while (temp.Count != key)
            {
                temp.Add(dict[key][0]);
                dict[key].RemoveAt(0);
            }
            result.Add(temp);
            if(dict[key].Count == 0)
                dict.Remove(key);
        }
        
        return result;
    }
}