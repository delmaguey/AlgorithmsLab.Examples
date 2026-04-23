// Given a string s, find the length of the longest substring without repeating characters.
// A substring is a contiguous sequence of characters within a string.

// A string s (length ≥ 0)

// Output
// An integer representing the length of the longest substring without duplicate characters.

// Input: s = "abcabcbb"
// Output: 3
// Explanation: "abc" is the longest substring

// Input: s = "bbbbb"
// Output: 1
// Explanation: "b"

// Input: s = "pwwkew"
// Output: 3
// Explanation: "wke"


namespace Arrays;

public static class LongestSubstring
{
    public static int Solve(string s)
    {
        // Create hashset to store characters that don't repeat
        HashSet<char> tmp = new ();
        int left =0;
        int right = 0;
        int counter = 0;

        // Iterate through string until the end is reached
        while (right < s.Length)
        {
            // Verify if the current character is not in the hashset, if it is not, add it to the hashset and move the start pointer forward, if it is in the hashset, clear the hashset and start over
            if (!tmp.Contains(s[right]))
            {
                tmp.Add(s[right]);
                counter = Math.Max(counter, tmp.Count);
                right++;
            }
            else
            {
                while (tmp.Contains(s[right]))
                {
                    tmp.Remove(s[left]);
                    left++;
                }
            }
        }

        return counter;
    }
}