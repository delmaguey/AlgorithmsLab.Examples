using System.Security.AccessControl;

namespace Arrays;

// You are given a string s and an integer k.
// You can replace at most k characters in the string so that the resulting substring contains only one repeating character.
// Return the length of the longest possible substring after performing at most k replacements.

// Examples:

//Input: s = "ABAB", k = 2
//Output: 4
// ---
// Input: s = "AABABBA", k = 1
// Output: 4

public static class LongestRepeatingCharacter
{
    public static int Solve(string s, int k)
    {
        int left = 0;
        int maxcount = 0;
        int result = 0;
        Dictionary<char, int> dict = new();

        // Iterate through the string with a right pointer
        for (int right = 0; right < s.Length; right++)
        {
            // If the character at the right pointer is not in the dictionary, add it with a value of 0
            if (!dict.ContainsKey(s[right]))
                dict[s[right]] = 0;
    
            // Move the right pointer and update the count of the character found
            dict[s[right]]++;

            // Update the maximum count of any character in the current window
            maxcount = Math.Max(maxcount, dict[s[right]]);

            // Verify if the current window size minus the count of the most frequent character is greater than k
            if ((right - left + 1) - maxcount > k)
            {
                dict[s[left]]--;
                left++;
            }

            // Update the result with the maximum length of the valid window found
            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}