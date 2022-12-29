public class Solution
{
    public int ClosetTarget(string[] words, string target, int startIndex)
    {
        var ret = int.MaxValue;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] != target)
                continue;
            var dist1 = Math.Abs(startIndex - i);
            var dist2 = Math.Abs(dist1 - words.Length);
            ret = Math.Min(ret, Math.Min(dist1, dist2));
        }

        return ret == int.MaxValue ? -1 : ret;
    }
}