public class NumArray
{
    private int[] _prefixSum;

    public NumArray(int[] nums)
    {
        _prefixSum = new int[nums.Length + 2];
        _prefixSum[0] = 0;
        for (int i = 0; i < nums.Length; i++)
            _prefixSum[i + 1] = _prefixSum[i] + nums[i];
    }

    public int SumRange(int left, int right)
        => _prefixSum[right + 1] - _prefixSum[left];
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
