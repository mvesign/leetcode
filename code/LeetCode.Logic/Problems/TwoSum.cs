using LeetCode.Core;

namespace LeetCode.Logic.Problems;

public class TwoSum : IProblem<int[]>
{
    public int[] Input { get; set; } = [];
    
    public int Target { get; set; }

    public int[] Solve()
    {
        var indexByValue = new Dictionary<int, int>();

        for (var i = 0; i < this.Input.Length; i++)
        {
            var complement = this.Target - this.Input[i];
            if (indexByValue.TryGetValue(complement, out var j))
            {
                return [j, i];
            }

            indexByValue[this.Input[i]] = i;
        }

        throw new ArgumentException("No two sum solution exists for the given input.");
    }
}
