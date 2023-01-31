using FluentAssertions;
using WilsonNetoDev.Utils;

namespace WilsonNetoDev.Utils.UnitTests;

public class ArrayUtilsTests
{
    [Theory]
    [InlineData(new int[]{ 1, 2, 3, 2, 1 }, 3)]
    [InlineData(new int[]{ 1, 3, 4, 2, 3, 2, 1 }, 4)]
    public void SingleNumber_ReceiveValidArray_ReturnsSingle(
        int[] nums,
        int expectedSingle)
        => ArrayUtils.SingleNumber(nums).Should().Be(expectedSingle);
}