// Problem: Valid Anagram
// Difficulty: Easy
// Link: https://leetcode.com/problems/valid-anagram/

namespace LeetCode.Problems.Problems;

public class P242ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        return s.Length == t.Length && s.OrderBy(a => a).SequenceEqual(t.OrderBy(a => a));
    }

    public bool IsAnagram2(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var sArr = s.OrderBy(a => a).ToArray();
        var tArr = t.OrderBy(a => a).ToArray();

        for (var i = 0; i < s.Length; i++)
        {
            if (sArr[i] != tArr[i]) return false;
        }

        return true;
    }

    public bool IsAnagram3(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var stats = new int[26];

        foreach (var sChar in s)
        {
            stats[sChar - 'a']++;
        }

        foreach (var tChar in t)
        {
            stats[tChar - 'a']--;

            if (stats[tChar - 'a'] < 0)
                return false;
        }

        return true;
    }
    
    public bool IsAnagram4(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var stats = new int[26];
        Array.Fill(stats, 0);

        for (var i = 0; i < s.Length; i++)
        {
            stats[s[i] - 'a']++;
            stats[t[i] - 'a']--;
        }

        for (var i = 0; i < 26; i++)
        {
            if (stats[i] != 0) return false;
        }

        return true;
    }
}