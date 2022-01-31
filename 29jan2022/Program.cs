/*
Concepts to review:
-overloading
-overriding
-exceptions
-ToString
-var (uses for it)
-Debugging!!!
*/
using System;
namespace PracticeWithStrings
{
    public abstract class TextConverter
    {
        public virtual void GetMessage()
        {
            //Do stuff
        }
        public virtual void Convert(string message)
        {
            //Do stuff
        }
    }
    public class PigLatinConverter : TextConverter
    {
        private string firstLetterOfWord = "";
        private string restOfWord = "";
        private string newWord = "";
        private string wordEnding = "";

        private bool firstLetterIsVowel()
        {
            if (firstLetterOfWord == "a" || firstLetterOfWord == "e" || firstLetterOfWord == "i" || firstLetterOfWord == "o" || firstLetterOfWord == "u")
            {
                return true;
            }
            return false;
        }
        public override void GetMessage()
        { 
            string originalMessage = Console.ReadLine("Write the message here:").Trim();
            Console.WriteLine("Thank you for inputting a message! Your message will be converted shortly.");
            Console.WriteLine("Converting...");
            Convert();                  
        }
        public override void Convert(string message)
        {
            List<string> ConvertedMessage;
            string[] Words = message.Split(" ");
            foreach (var word in Words)
        {
            // split the word into its first letter and its last part
            firstLetterOfWord = word.Substring(0,1).ToLower();
            if (firstLetterIsVowel())
            {
                wordEnding = "way";
                restOfWord = word;
                newWord = restOfWord + wordEnding;
            }
            else
            {
                wordEnding = "ay";
                restOfWord = word.Substring(1,word.Length);
                newWord = restOfWord + firstLetterOfWord + wordEnding;
            }
            //ConvertedMessage.Add(newWord);
        }            
        }
    }
}