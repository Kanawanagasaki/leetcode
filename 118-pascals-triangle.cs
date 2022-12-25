public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var ret = new List<IList<int>>() { new List<int>() { 1 } };

        for (int i = 1; i < numRows; i++)
        {
            var row = new List<int>();
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                    row.Add(1);
                else
                    row.Add(ret[i - 1][j - 1] + ret[i - 1][j]);
            }
            ret.Add(row);
        }

        return ret;
    }
}
