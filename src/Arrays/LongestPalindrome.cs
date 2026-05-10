public static class LongestPalindrome
{
    public static string Solve(string s)
    {
        int start = 0;
        int maxLength = 0;

        // Iterate through each character in the string
        for (int i = 0;i<s.Length;i++)
        {
            // Expand window for odd and even lenghts
            int[] odd  = ExpandWindow(s, i, i);
            int[] even = ExpandWindow(s, i, i + 1);

            // check odd
            int oddLen = odd[1] - odd[0] + 1;
            if (oddLen > maxLength) {
                maxLength = oddLen;
                start = odd[0];
            }

            // check even
            int evenLen = even[1] - even[0] + 1;
            if (evenLen > maxLength) {
                maxLength = evenLen;
                start = even[0];
            }

        }

        return s.Substring(start, maxLength);

    }

    // expand the window until the characters in both sides are the same
    private static int[] ExpandWindow(string s, int left, int right) {
            
        while(left >=0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return new int[] { left + 1, right - 1 };

    }


    
}