// Problem: Two Sum
// Difficulty: Easy
// Link: https://leetcode.com/problems/two-sum/

namespace LeetCode.Problems.Problems;

public class P1TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                if (i == j) continue;
                if (nums[i] + nums[j] == target) return new[] { i, j };
            }
        }
        throw new Exception("Not found");
    }
    
    public int[] TwoSum2(int[] nums, int target)
    {
        var numbers = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (numbers.ContainsKey(complement))
                return new[] { numbers[complement], i };

            if (!numbers.ContainsKey(nums[i]))
                numbers.Add(nums[i], i);
        }

        throw new Exception("Not found");
    }
}