using LeetCode.Problems.Problems;

namespace LeetCode.Tests.Problems;

public class ContainsDuplicate217Test
{
    private readonly P217ContainsDuplicate _containsDuplicate;

    public ContainsDuplicate217Test()
    {
        _containsDuplicate = new P217ContainsDuplicate();
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    [InlineData(new int[] { }, false)]
    public void ContainsDuplicate_ReturnsExpectedResult(int[] nums, bool expectedResult)
    {
        var result = _containsDuplicate.ContainsDuplicate(nums);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    [InlineData(new int[] { }, false)]
    public void ContainsDuplicate2_ReturnsExpectedResult(int[] nums, bool expectedResult)
    {
        var result = _containsDuplicate.ContainsDuplicate2(nums);
        Assert.Equal(expectedResult, result);
    }
}