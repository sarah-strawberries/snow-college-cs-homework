﻿using System;
class Program
{
    class PigLatin
{
    public static string ending = "ay";
    private static string firstLetterOfWord;
    private static string restOfWord;
    private static string newWord;
    public string [] words = new string [100];
    public string [] translatedWords = new string [100];
    public void Convert(string text) 
    {
       string [] words = text.Split(" ");
        foreach (var word in words)
        {
            // split the word into its first letter and its last part
            firstLetterOfWord = word.Substring(0,1);
            restOfWord = word.Substring(1,word.Length);
            newWord = restOfWord + firstLetterOfWord + ending;
            translatedWords.Add(newWord);
        }
        foreach (var word in translatedWords)
        {
            Console.Write(word + " ");
        }

    }

}
}
