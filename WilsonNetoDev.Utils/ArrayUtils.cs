namespace WilsonNetoDev.Utils;

public static class ArrayUtils
{
    public static int SingleNumber(int[] nums)
    {
        int bitHolder = 0;
        foreach(int num in nums) bitHolder ^= num;
        return bitHolder;
    }
}
