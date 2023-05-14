using LeetCode.Problems.Problems;

namespace LeetCode.Tests.Problems;

public class P36ValidSudokuTest
{
    private readonly P36ValidSudoku _class;

    public P36ValidSudokuTest()
    {
        _class = new P36ValidSudoku();
    }

    [Fact]
    public void IsValidSudoku_ValidBoard_ReturnsTrue()
    {
        // Arrange
        char[][] board =
        {
            new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };

        // Act
        var result = _class.IsValidSudoku(board);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidSudoku_InvalidBoard_ReturnsFalse()
    {
        // Arrange
        char[][] board =
        {
            new[] { '8', '3', '.', '.', '7', '.', '.', '3', '.' },
            new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };

        // Act
        var result = _class.IsValidSudoku(board);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidSudoku2_ValidBoard_ReturnsTrue()
    {
        // Arrange
        char[][] board =
        {
            new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };

        // Act
        var result = _class.IsValidSudoku2(board);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidSudoku2_InvalidBoard_ReturnsFalse()
    {
        // Arrange
        char[][] board =
        {
            new[] { '8', '3', '.', '.', '7', '.', '.', '3', '.' },
            new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };

        // Act
        var result = _class.IsValidSudoku2(board);

        // Assert
        Assert.False(result);
    }
}