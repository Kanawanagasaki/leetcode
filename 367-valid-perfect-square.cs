public class Solution
{
    public bool IsPerfectSquare(int num)
        => Math.Pow((int) Math.Sqrt(num), 2) == num;
}
