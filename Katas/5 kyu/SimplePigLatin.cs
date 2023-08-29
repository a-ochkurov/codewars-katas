using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace Katas;

public class SimplePigLatin
{
    public static string PigIt(string str)
    {
        string[] words = str.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            string punctuations = new string(word.Where(char.IsPunctuation).ToArray());
            string letters = new string(word.Where(char.IsLetter).ToArray());

            if (!string.IsNullOrEmpty(letters))
            {
                words[i] = $"{letters.Substring(1)}{letters[0]}ay{punctuations}";
            }
        }

        return string.Join(" ", words);
    }
}
