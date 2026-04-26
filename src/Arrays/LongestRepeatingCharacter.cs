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
        int right = 0;
        int left = 0;
        int maxcount = 0;
        int result = 0;
        Dictionary<char, int> dict = new();

        while(right < s.Length)
        {
            // If character is in the dictionary
            if(dict.ContainsKey(s[right]))
            {
                // update maxcount, get the most frequent character in the current window
                maxcount = Math.Max(maxcount, dict[s[right]]);

                // Get the size of the current window
                int windowSize = right - left + 1;

                // If the number of characters that need to be replaced is greater than k, shrink the window from the left
                if (windowSize - maxcount > k)
                {
                    // shrink window from the left
                    dict[s[left]]--;
                    left++;
                }

                dict[s[right]]++;
                right++;

            }
            else
            {
                dict[s[right]] = 1;
                right++;
            }

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}