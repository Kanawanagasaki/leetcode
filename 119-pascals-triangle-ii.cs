public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        var ret = new List<int>() { 1 };
        for (int i = 1; i <= rowIndex; i++)
        {
            var buff = new List<int>();

            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                    buff.Add(1);
                else
                    buff.Add(ret[j - 1] + ret[j]);
            }

            ret = buff;
        }
        return ret;
    }
}