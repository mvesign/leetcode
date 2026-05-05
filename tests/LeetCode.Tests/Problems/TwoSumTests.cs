using LeetCode.Solutions.Problems;
using NUnit.Framework;

namespace LeetCode.Tests.Problems;

public class TwoSumTests
{
    [Test]
    public void TwoSum_ReturnsExpectedIndices_ForSimpleInput()
    {
        var solution = new TwoSumSolution();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        var result = solution.TwoSum(nums, target);

        Assert.AreEqual(new[] { 0, 1 }, result);
    }

    [Test]
    public void TwoSum_ReturnsExpectedIndices_ForNegativeValues()
    {
        var solution = new TwoSumSolution();
        int[] nums = { -3, 4, 3, 90 };
        int target = 0;

        var result = solution.TwoSum(nums, target);

        Assert.AreEqual(new[] { 0, 2 }, result);
    }
}
