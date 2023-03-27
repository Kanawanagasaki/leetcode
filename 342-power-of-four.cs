public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        double power = Math.Log(n, 4);
        return power == (int)power;
    }
}