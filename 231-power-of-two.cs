using System;

public class Solution
{
    public bool IsPowerOfTwo(int n)
        => Math.Round(Math.Log2(n), 10) % 1 == 0;
}