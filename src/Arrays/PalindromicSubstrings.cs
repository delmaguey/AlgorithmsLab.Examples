using System.Text;

namespace Arrays
{
    public static class PalindromicSubstrings
    {
        public static int Solve(string s)
        {
            StringBuilder tmp = new();
            List<string> str = new();

            for(int i=0; i<s.Length; i++)
            {
                tmp.Append(s[i]);
                if(IsPalindrome(tmp))
                {
                    str.Add(tmp.ToString());
                }
            }

            return str.Count();
        }

        private static bool IsPalindrome(StringBuilder tmp)
        {
            if(tmp.Length==1)
                return true;
            
            int left = 0, right = tmp.Length - 1;
            while (left < right)
            {
                if (tmp[left] != tmp[right]) return false;
                left++;
                right--;
            }
            return true;

        }
    }
}