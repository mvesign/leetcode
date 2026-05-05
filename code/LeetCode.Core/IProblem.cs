namespace LeetCode.Core;

public interface IProblem<TResult>
{
    public TResult Solve();
}