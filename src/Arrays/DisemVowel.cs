using System.Text;

namespace AlgoritmosLab.Arrays;

public static class Disem
{
    public static string DisemVowel(string str)
    {
        StringBuilder temp = new StringBuilder();
        HashSet<char> vocales = new HashSet<char>{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        
        for(int i=0;i<str.Length;i++)
        {
            if(!vocales.Contains(str[i]))
                temp.Append(str[i]);
        }

        return temp.ToString();
    }
}