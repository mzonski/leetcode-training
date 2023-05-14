using LeetCode.Problems.Problems;

namespace LeetCode.Tests.Problems;

public class P242ValidAnagramTest
{
    private readonly P242ValidAnagram _class;

    public P242ValidAnagramTest()
    {
        _class = new P242ValidAnagram();
    }

    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    public void IsAnagram_ReturnsExpectedResult(string s, string t, bool expectedResult)
    {
        var result = _class.IsAnagram(s, t);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    public void IsAnagram2_ReturnsExpectedResult(string s, string t, bool expectedResult)
    {
        var result = _class.IsAnagram2(s, t);
        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    public void IsAnagram3_ReturnsExpectedResult(string s, string t, bool expectedResult)
    {
        var result = _class.IsAnagram3(s, t);
        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    public void IsAnagram4_ReturnsExpectedResult(string s, string t, bool expectedResult)
    {
        var result = _class.IsAnagram4(s, t);
        Assert.Equal(expectedResult, result);
    }
}