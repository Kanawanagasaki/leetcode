using System;

// I failed 3 submissions while was trying to figure out
// digits parameter for Math.Round

// We need to use Math.Round because of double floating point inconsistancy

public class Solution
{
    public bool IsPowerOfThree(int n)
        => Math.Round(Math.Log(n, 3), 10) % 1 == 0;
}