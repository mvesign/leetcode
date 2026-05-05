namespace LeetCode.Solutions.Problems;

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var indexByValue = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (indexByValue.TryGetValue(complement, out var j))
            {
                return [j, i];
            }

            indexByValue[nums[i]] = i;
        }

        throw new ArgumentException("No two sum solution exists for the given input.");
    }
}
