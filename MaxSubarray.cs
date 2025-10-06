namespace Leetcode;

public class MaxSubarray
{
    public int MaxSubArray(int[] nums)
    {
        int n = nums.Length;

        int[] numDP = new int[nums.Length];
        numDP[0] = nums[0];
        int max = int.MinValue;

        for (int i = 1; i < n; i++)
        {
            numDP[i] = nums[i] > numDP[i - 1] + nums[i] ? nums[i] : numDP[i - 1] + nums[i];
            if (max < numDP[i])
                max = numDP[i];
        }

        return max;
    }
}