using System.Text;

namespace Arrays;

/*
Given an array of integers nums and an integer target, return the indices i and j 
such that nums[i] + nums[j] == target and i != j.

You may assume that every input has exactly one pair of indices i and j that satisfy the condition.

Return the answer with the smaller index first.

Example 1:

Input: 
nums = [3,4,5,6], target = 7

Output: [0,1]
Explanation: nums[0] + nums[1] == 7, so we return [0, 1].

Example 2:

Input: nums = [4,5,6], target = 10

Output: [0,2]
Example 3:

Input: nums = [5,5], target = 10

Output: [0,1]
Constraints:

2 <= nums.length <= 1000
-10,000,000 <= nums[i] <= 10,000,000
-10,000,000 <= target <= 10,000,000
Only one valid answer exists.
*/
public static class TwoSum {
    public static int[] Solve(int[] nums, int target) {

        if(nums.Length < 2 || nums.Length > 1000)
        {
            throw new ArgumentException("Array length is not valid. There should be at least 2 elements and at most 1000 elements.");
        }

        // Starting Two Pointers
        int start = 0;
        int end = nums.Length-1;

        //Iterate until two pointers are different
        while (start < end)
        {
            // Sum the values of the pointers
            int temp = nums[start]+nums[end];
            if (temp == target)
            {
                //If the sum is equal to target, return the indices ofthe pointers
                return new int[]{start, end};
            }
            else if (temp > target)
            {
                // Since the array is sorted, if the sum is greater than target, increment the pointer of end variable
                end--;
            }
            else
            {
                // if the sum is less than target, increment the pointer of start variable
                start++;
            }
        }

        return [];

    }
}