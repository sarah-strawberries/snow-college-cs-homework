using System.Diagnostics;

namespace ThisKeywordPractice
{
    class Program
    {
        public class Printer
        {
            public static void PrintMessage(string text)
            {
                Console.WriteLine(text);
            }

        }
        public class NotUsefulClass
        {
            public string message = "This is some text. We can borrow a method from the other class to print it to the console.";

            public void OkayMaybeSomewhatUseful()
            {
                Printer.PrintMessage(this.message);
            }

        }
            static void Main()
            {
                NotUsefulClass doStuff = new NotUsefulClass();
                doStuff.OkayMaybeSomewhatUseful();
            }
    }

}