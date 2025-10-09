namespace Leetcode;

public class SpellsAndPotions
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions, (a, b) => b - a);
        int n = potions.Length;
        int[] result = new int[spells.Length];

        for (int i = 0; i < spells.Length; i++)
        {
            long spell = spells[i];

            long minPotion = success % spell == 0 ? success / spell : success / spell + 1;


            int index = Array.BinarySearch(potions, (int)Math.Min(minPotion, int.MaxValue));
            if (index < 0) index = ~index;
            result[i] = n - index;
        }

        return result;
    }
}