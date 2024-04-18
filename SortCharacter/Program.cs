using System;
using System.Text;

namespace SortCharacter;

public class Program
{
    public static string ProcVowel(string param)
    {
        const string vowel = "aeiou";
        List<char> result = new List<char>();

        foreach (char character in param.ToLower())
        {
            if (char.IsLetter(character))
            {
                if (vowel.IndexOf(character) >= 0)
                {
                    int index = result.IndexOf(character); 
                    if( index >=0)
                    {
                        result.Insert(index,character);

                    } else {

                        result.Add(character);
                    }
                }
            }
        }
        string resultString = new(result.ToArray());
        return resultString;
    }

    public static string ProcConsonant(string param)
    {
        List<char> result = new List<char>();
        const string vowel = "aeiou";
        foreach (char character in param.ToLower())
        {
            if (char.IsLetter(character))
            {
                if (vowel.IndexOf(character) == -1)
                {
                    int index = result.IndexOf(character); 
                    if( index >=0)
                    {
                        result.Insert(index,character);

                    } else {

                        result.Add(character);
                    }
                }
            }
        }
        string resultString = new(result.ToArray());
        return resultString;
    }

    public static void Main(string[] args)
    {
        Console.Write("Input one line of words (S) : ");
        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("You write nothing");
        }
        else
        {
            string charVowel = ProcVowel(input);
            string charConsonant = ProcConsonant(input);

            Console.WriteLine("Vowel Characters : ");
            Console.WriteLine(charVowel);
            Console.WriteLine("Consonant Characters : ");
            Console.WriteLine(charConsonant);
        }
    }
}
