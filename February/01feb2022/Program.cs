using System;
namespace PracticeWithDelagates
{
    public delegate bool DoChores(int choreNum);
    public class MyChores
    {
        public static int choreNumber;
        public static int DoChore()
        {
            if (choreNumber == 0)
            {
                Console.WriteLine("You swept the floor!");
                choreNumber++;
                return choreNumber;
            }
            if(choreNumber == 1)
            {
                Console.WriteLine("You did the dishes!");
                choreNumber++;
                return choreNumber;
            }
            if (choreNumber == 2)
            {
                Console.WriteLine("You cleaned your room!");
                choreNumber++;
                return choreNumber;
            }
            else
            {
                Console.WriteLine("You washed a window!");
                return choreNumber;
            }
        }
        public int ChoreCount()
        {
            Console.WriteLine($"You have completed {choreNumber} chores.");
            return 0;
        }
    }
    public static Main()
    {
        DoChores(DoChore);
    }
}