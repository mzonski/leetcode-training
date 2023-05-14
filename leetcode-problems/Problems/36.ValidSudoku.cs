// Problem: Valid Sudoku
// Difficulty: Medium
// Link: https://leetcode.com/problems/valid-sudoku/

namespace LeetCode.Problems.Problems;

public class P36ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        var set = new HashSet<char>();

        // Validate columns
        for (var columnIdx = 0; columnIdx < 9; columnIdx++)
        {
            set.Clear();
            for (var rowIdx = 0; rowIdx < 9; rowIdx++)
            {
                var cChar = board[rowIdx][columnIdx];
                if (cChar == '.') continue;
                if (set.Contains(cChar)) return false;
                set.Add(cChar);
            }
        }
        
        // Validate rows
        for (var columnIdx = 0; columnIdx < 9; columnIdx++)
        {
            set.Clear();
            for (var rowIdx = 0; rowIdx < 9; rowIdx++)
            {
                var cChar = board[columnIdx][rowIdx];
                if (cChar == '.') continue;
                if (set.Contains(cChar)) return false;
                set.Add(cChar);
            }
        }

        // Validate boxes
        for (var boxIdx = 0; boxIdx < 9; boxIdx++)
        {
            set.Clear();
            var boxStartRow = (boxIdx / 3) * 3;
            var boxStartCol = (boxIdx % 3) * 3;

            for (var rowIdx = boxStartRow; rowIdx < boxStartRow + 3; rowIdx++)
            {
                for (var columnIdx = boxStartCol; columnIdx < boxStartCol + 3; columnIdx++)
                {
                    var cChar = board[columnIdx][rowIdx];
                    if (cChar == '.') continue;
                    if (set.Contains(cChar)) return false;
                    set.Add(cChar);
                }
            }
        }

        return true;
    }
    
    public bool IsValidSudoku2(char[][] board)
    {
        var tempArray = new int[9];

        // Validate columns
        for (var columnIdx = 0; columnIdx < 9; columnIdx++)
        {
            Array.Fill(tempArray, 0);
            for (var rowIdx = 0; rowIdx < 9; rowIdx++)
            {
                var index = board[rowIdx][columnIdx] - '0' - 1;
                if (index < 0) continue;
                tempArray[index]++;
            }

            for (var i = 0; i < 9; i++)
            {
                if (tempArray[i] > 1) return false;
            }
        }

        // Validate rows
        for (var columnIdx = 0; columnIdx < 9; columnIdx++)
        {
            Array.Fill(tempArray, 0);
            for (var rowIdx = 0; rowIdx < 9; rowIdx++)

            {
                var index = board[columnIdx][rowIdx] - '0' - 1;
                if (index < 0) continue;
                tempArray[index]++;
            }

            for (var i = 0; i < 9; i++)
            {
                if (tempArray[i] > 1) return false;
            }
        }

        // Validate boxes
        for (var boxIdx = 0; boxIdx < 9; boxIdx++)
        {
            Array.Fill(tempArray, 0);
            var boxStartRow = (boxIdx / 3) * 3;
            var boxStartCol = (boxIdx % 3) * 3;

            for (var rowIdx = boxStartRow; rowIdx < boxStartRow + 3; rowIdx++)
            {
                for (var columnIdx = boxStartCol; columnIdx < boxStartCol + 3; columnIdx++)
                {
                    var index = board[columnIdx][rowIdx] - '0' - 1;
                    if (index < 0) continue;
                    tempArray[index]++;
                }
            }

            for (var i = 0; i < 9; i++)
            {
                if (tempArray[i] > 1) return false;
            }
        }

        Array.Clear(tempArray);

        return true;
    }
}