// using System;
// namespace PracticeWithStrings
// {
//     class Program
//     {
//         public class PigLatinConverter
//         {
//             public string Message { get; private set; }
//             private string firstLetterOfWord;
//             private string restOfWord;
//             private string newWord;
//             private string wordEnding;
//             //     public void GetMessage()
//             //     {
//             //         Console.WriteLine("Write your message here: ");
//             //         public string? Message = Console.ReadLine().Trim();
//             // }
//             public void GetMessage()
//             {
//                 Console.WriteLine("Write your message here: ");
//                 string Message = Console.ReadLine().Trim().ToLower();
//             }

//             private bool firstLetterIsVowel()
//             {

//                 string firstLetter = Message[0];
//                 {
//                     if (firstLetter == "a" || firstLetter == "e" || firstLetter == "i" || firstLetter == "o" || firstLetter == "u")
//                         return true;
//                 }
//                 return false;
//             }
    
//             public void Convert(string message)
//             {
//                 List<string> ConvertedMessage = new List<string>();
//                 string[] Words = message.Split(" ");
//                 foreach (var word in Words)
//                 {
//                     firstLetterOfWord = word.Substring(0, 1).ToLower();
//                     if (firstLetterIsVowel())
//                     {
//                         wordEnding = "way";
//                         restOfWord = word;
//                         newWord = restOfWord + wordEnding;
//                         ConvertedMessage.Add(newWord);
//                     }
//                     else
//                     {
//                         wordEnding = "ay";
//                         restOfWord = word.Substring(1, word.Length);
//                         newWord = restOfWord + firstLetterOfWord + wordEnding;
//                         ConvertedMessage.Add(newWord);
//                     }
//                 }
//             }
//         }

//         public void Main()
//         {

//         }
//     }
// }