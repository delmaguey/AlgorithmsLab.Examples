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

    Dictionary<char, int> dict1 = new();
    Dictionary<char, int> dict2 = new();

    if(s.Length != t.Length) return false;

    // Iterate through both strings and count each character currences.
    for(int i=0;i<s.Length;i++)
    {
        if(dict1.ContainsKey(s[i]))
            dict1[s[i]]++;
        else
            dict1[s[i]] = 1;
    
        if(dict2.ContainsKey(t[i]))
            dict2[t[i]]++;
        else
            dict2[t[i]] = 1;
    }

    // Iterate through dictionaries to validate if they have the same number of characters. If not, return false.
    foreach(var item in dict1)
    {
        if(!dict2.ContainsKey(item.Key))
            return false;
    }

    return true;

    }

}