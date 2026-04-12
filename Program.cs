using AlgoritmosLab.Arrays;
using Arrays;

Console.WriteLine("--- Executing Algorithms ---");

Console.WriteLine("");

// Exercise: Disemvowel
// String txt = "This website is for losers LOL!";
// String res = Disem.DisemVowel(txt);Console.WriteLine($"The text without vowels is: {res}");


// Exercise: TwoSum
int[] nums = [4,5,7];
int target = 10;
int[] res = TwoSum.Solve(nums, target);
if (res.Length != 0)
    Console.WriteLine($"The indices of the two numbers that add up to {target} are: [{res[0]}, {res[1]}]");
else
    Console.WriteLine($"No two numbers add up to {target}.");
