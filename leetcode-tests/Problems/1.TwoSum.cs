using LeetCode.Problems.Problems;

namespace LeetCode.Tests.Problems;

public class P1TwoSumTest
{
    private readonly P1TwoSum _class;

    public P1TwoSumTest()
    {
        _class = new P1TwoSum();
    }

    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void TwoSum_ReturnsExpectedResult(int[] nums, int target, int[] expectedResult)
    {
        var result = _class.TwoSum(nums, target);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void TwoSum2_ReturnsExpectedResult(int[] nums, int target, int[] expectedResult)
    {
        var result = _class.TwoSum2(nums, target);
        Assert.Equal(expectedResult, result);
    }
}