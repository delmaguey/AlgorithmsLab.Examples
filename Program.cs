using AlgoritmosLab.Arrays;
using Arrays;
using Sorting;

Console.WriteLine("--- Executing Algorithms ---");

Console.WriteLine("");

// Exercise: Disemvowel
// String txt = "This website is for losers LOL!";
// String res = Disem.DisemVowel(txt);Console.WriteLine($"The text without vowels is: {res}");


// Exercise: TwoSum
// int[] nums = [4];
// int target = 10;
// int[] res = TwoSum.Solve(nums, target);
// if (res.Length != 0)
//     Console.WriteLine($"The indices of the two numbers that add up to {target} are: [{res[0]}, {res[1]}]");
// else
//     Console.WriteLine($"No two numbers add up to {target}.");


// Exercise: IsAnagram
// string s = "racecar";
// string t = "carrace";

// bool res = IsAnagram.Solve(s, t);
// Console.WriteLine("Is Anagram: " + res.ToString());


// Exercise: Quick Sort
// int[] arr = [64, 34, 25, 12, 22, 11, 90];
// Console.WriteLine("Unsorted array: " + string.Join(", ", arr));
// QuickSort.Sort(arr, 0, arr.Length - 1);
// Console.WriteLine("Sorted array:   " + string.Join(", ", arr));


// Exercise: Longest Substring Without Repeating Characters
//string s = "abcabcbb";
// string s = "pwwkew";
// int res = LongestSubstring.Solve(s);
// Console.WriteLine($"Length of the longest substring: {res}");


// Exercise: Longest Repeating Character Replacement
// string s = "AABABBA";
// int k = 1;
//  string s = "ABAB";
//  int k = 2;
// int res = LongestRepeatingCharacter.Solve(s, k);
// Console.WriteLine($"Length of the longest substring after replacements: {res}");

// Exercise: Longest Palindromic Substring

// Example 1:
// Input: string s = "babad";
// Output: "bab"
// Explanation: "aba" is also a valid answer.

// Example 2:
// Input: s = "cbbd"
// Output: "bb"
// string res = LongestPalindrome.Solve("babad");
// Console.WriteLine($"Longest palindromic substring: {res}");



// Exercise: Container With Most Water
// Example 1:
// Input: height = [1,8,6,2,5,4,8,3,7]
// Output: 49
// Example 2:
// Input: height = [1,1]
// Output: 1
//int[] height = [1,8,6,2,5,4,8,3,7];
// int[] height = [8,7,2,1];
// int res = ContainerMostWater.Solve(height);
// Console.WriteLine($"Solution: {res}");



//Excercise: Permutation in String
// Example 1:
// Input: s1 = "ab", s2 = "eidbaooo
// Output: true
// Explanation: s2 contains one permutation of s1 ("ba").
// Example 2:
// Input: s1 = "ab", s2 = "eidboaoo"
// Output: false
string s1 = "ab";
string s2 = "eidbaoo";
bool res = PermutationInString.Solve(s1,s2);
Console.WriteLine($"Have permutation: {res}");
