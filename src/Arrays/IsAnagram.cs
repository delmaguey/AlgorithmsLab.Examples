namespace Arrays;

/*
Given two strings s and t, return true if the two strings are anagrams of each other, otherwise return false.

An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.

Example 1:

Input: s = "racecar", t = "carrace"

Output: true
Example 2:

Input: s = "jar", t = "jam"

Output: false
Constraints:

s and t consist of lowercase English letters.
*/

public static class IsAnagram {

public static bool Solve(string s, string t) {

    if(s.Length != t.Length) return false;

    // Allocate an array of 26 rooms to count ocurrences of each character.
    int[] count = new int[26];

    // Iterate through both strings and count ocurrences of each character.
    for (int i = 0; i < s.Length; i++) {
        count[s[i] - 'a']++;
        count[t[i] - 'a']--;
    }

    // If the count of any character is not zero, then the strings are not anagrams.
    foreach (int val in count) {
        if (val != 0) {
            return false;
        }
    }
    
    return true;

    }

}