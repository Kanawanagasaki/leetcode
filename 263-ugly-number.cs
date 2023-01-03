public class Solution
{
    public bool IsUgly(int n)
    {
        if(n <= 0)
            return false;

        var primes = new[] { 2d, 3d, 5d };
        while(n > 1)
        {
            bool found = false;
            foreach(var prime in primes)
            {
                var step = n / prime;
                if(step % 1 == 0d)
                {
                    n = (int)step;
                    found = true;
                    break;
                }
            }
            if(!found)
                return false;
        }

        return true;
    }
}
