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
int[] arr = [64, 34, 25, 12, 22, 11, 90];
Console.WriteLine("Unsorted array: " + string.Join(", ", arr));
QuickSort.Sort(arr, 0, arr.Length - 1);
Console.WriteLine("Sorted array:   " + string.Join(", ", arr));
