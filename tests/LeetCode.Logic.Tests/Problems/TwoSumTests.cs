using LeetCode.Logic.Problems;

namespace LeetCode.Logic.Tests.Problems;

[TestFixture]
public class TwoSumTests
{
    private TwoSum problem = null!;

    [SetUp]
    public void SetUp() =>
        this.problem = new TwoSum();

    [Test]
    [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void Given_Input_ReturnsExpectedIndices(
        int[] input,
        int target,
        int[] expected)
    {
        this.problem.Input = input;
        this.problem.Target = target;

        var result = this.problem.Solve();

        Assert.AreEqual(expected, result);
    }
}
