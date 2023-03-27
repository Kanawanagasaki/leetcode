public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var ret = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            var item = "";
            if (i % 3 == 0)
                item += "Fizz";
            if (i % 5 == 0)
                item += "Buzz";
            ret.Add(item == "" ? i.ToString() : item);
        }

        return ret;
    }
}