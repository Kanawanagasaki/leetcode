public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        string ret = "";
        bool leadingOne = false;

        for (int i = 1; i <= num1.Length || i <= num2.Length; i++)
        {
            int ch1 = i <= num1.Length ? num1[^i] - '0' : 0;
            int ch2 = i <= num2.Length ? num2[^i] - '0' : 0;
            int sum = ch1 + ch2;

            if (leadingOne)
            {
                sum++;
                leadingOne = false;
            }

            if (sum > 9)
            {
                leadingOne = true;
                sum -= 10;
            }

            ret = sum + ret;
        }

        if(leadingOne)
            ret = 1 + ret;

        return ret;
    }
}
