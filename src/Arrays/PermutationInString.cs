using System.Text;

namespace Arrays
{
    public static class PermutationInString
    {
        public static bool Solve(string s1, string s2)
        {
            int[] charCount = new int[26];
            int[] s2Count = new int[26];

            // Counting characters in both strings
            for (int i = 0; i < s1.Length; i++)
            {
                charCount[s1[i] - 'a']++;
                s2Count[s2[i] - 'a']++;
            }

            int start = 0;

            while(start <= s2.Length - s1.Length)
            {
                // Check if current window matches the character count
                if(Matches(charCount, s2Count))
                    return true;
                
                // Slide window
                if (start + s1.Length < s2.Length)
                {
                    // remove left char
                    s2Count[s2[start] - 'a']--;

                    // add new right char
                    s2Count[s2[start + s1.Length] - 'a']++;
                }

                start ++;
            }
            
            return false;
        }
        private static bool Matches(int[] charCount, int[] s)
        {
            // Check if character counts match
            for(int i=0;i<charCount.Length;i++)
            {
                // If any charcter count doesn't match, return false
                if(charCount[i] != s[i])
                    return false;
            }

            return true;
        }
    }
}