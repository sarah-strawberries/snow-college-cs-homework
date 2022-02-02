using System;
namespace PracticeWithDelagates
{
    public delegate bool DoChores(int choreNum);
    public class MyChores
    {
        public static int choreNumber = 0;
        public static int DoChore(int choreNum)
        {
            if (choreNum == 0)
            {
                Console.WriteLine("You swept the floor!");
                choreNumber = choreNum;
                return choreNumber;
            }
            if (choreNum == 1)
            {
                Console.WriteLine("You did the dishes!");
                choreNumber = choreNum;
                return choreNumber;
            }
            if (choreNum == 2)
            {
                Console.WriteLine("You cleaned your room!");
                choreNumber = choreNum;
                return choreNumber;
            }
            else
            {
                Console.WriteLine("You washed a window!");
                choreNumber = choreNum;
                return choreNumber;
            }

        }
        public int ChoreCount()
        {
            Console.WriteLine($"You have completed {choreNumber} chores.");
            return 0;
        }
    }
    public class Program
    {
        DoChores test = new DoChores(DoChore);

    }
}