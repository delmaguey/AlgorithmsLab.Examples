namespace Arrays
{
    public static class PermutationInString
    {
        public static bool Solve(string s1, string s2)
        {
            int[] count = new int[100];

            string permutation = "";

            if (s1.Length == 0)
            {
                return false;
            }
            if(s1.Length == 1)
            {
                permutation = s1;
            }
            if (s1.Length == 2)
            {
                permutation = s1[1].ToString() + s1[0].ToString();
            }
            if(s1.Length > 2)
            {
                return false;
            }

            for(int i = 0 ; i < s2.Length; i++)
            {
                if (s2.Contains(s1) || s2.Contains(permutation))
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}