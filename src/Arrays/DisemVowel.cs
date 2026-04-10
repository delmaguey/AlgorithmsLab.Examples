using System.Text;

namespace AlgoritmosLab.Arrays;


/*
Trolls are attacking your comment section! 
A common way to deal with this situation is to remove all of the vowels 
from the trolls' comments, neutralizing the threat. Your task is to write 
a function that takes a string and return a new string with all vowels removed. 
For example, the string "This website is for losers LOL!" 
would become "Ths wbst s fr lsrs LL!".
*/
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