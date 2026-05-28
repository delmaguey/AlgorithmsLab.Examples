using System.Text;

namespace Arrays
{
    public static class PalindromicSubstrings
    {
        public static int Solve(string s)
        {
            int countCharacters = 0;

            for(int i=0; i<s.Length; i++)
            {
                countCharacters+= ExpandWindow(s, i, i); // Odd length palindromes
                countCharacters+= ExpandWindow(s, i, i+1); // Even length palindromes
            }

            return countCharacters;
        }

        private static int ExpandWindow(string s, int left, int right)
        {
            int count = 0;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                count++;
                left--;
                right++;
            }
            return count;
        }
    }
}