// Problem: Contains Duplicate
// Difficulty: Easy
// Link: https://leetcode.com/problems/contains-duplicate/

namespace LeetCode.Problems.Problems;

public class P217ContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();

        foreach (var num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }

            set.Add(num);
        }

        return false;
    }

    public bool ContainsDuplicate2(int[] nums)
    {
        var set = new HashSet<int>(nums);
        return nums.Length != set.Count;
    }
}