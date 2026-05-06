public static class LongestPalindrome
{
    public static string Solve(string s)
    {
        int n = s.Length;
        string longest = "";
        for (int i = 0; i < n; i++) {
            for (int j = i; j < n; j++) {
                string substring = s.Substring(i, j - i + 1);
                
                if (IsPalindrome(substring) && substring.Length > longest.Length) {
                    longest = substring;
                }
            }
        }
        
        return longest;
    }

    private static bool IsPalindrome(string str) {
        int left = 0;
        int right = str.Length - 1;
        
        while (left < right) {
            if (str[left] != str[right]) {
                return false;
            }
            left++;
            right--;
        }
        
        return true;
    }
}